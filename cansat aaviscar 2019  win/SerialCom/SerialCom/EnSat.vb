Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml

Public Class EnSat
    '------------------------------------------------
    Dim myPort As Array
    Dim TempToProgressBar As Single
    Dim vpb_sy, vpb_ly As Integer
    Dim ChartLimit As Integer = 30
    Dim TempL, HumL, AltiL, DustL, AxxL, AyyL, AzzL, timL As Integer
    Dim temperature, humidity, altitude As Integer
    Dim dustf As Single
    Dim FilePathAndName As String
    Dim Accex, Accey, Accez, timef As String
    Dim Lun, LunF As String
    Dim LunL As Integer
    Dim type As String

    Dim Cal = "Bettle_Sat"

    Dim X As String


    Dim Temp, Hum, Alti, TempResult, HumResult, AltiResult, Dust, Dustresult, Axx, Ayy, Azz, tim As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        X = "Lunar Zone"
        GroupBox4.Hide()
        GroupBox5.Show()






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        X = "Decent data"

        GroupBox4.Show()
        GroupBox5.Hide()
        Label21.Text = AltiResult
        Label26.Text = Accex
        Label22.Text = Accey
        Label24.Text = Accez






    End Sub

    Private Sub ButtonStartRecording_Click(sender As Object, e As EventArgs) Handles ButtonStartRecording.Click
        ButtonStartRecording.Enabled = False
        ButtonStopRecording.Enabled = True
        ButtonSaveTOExcel.Enabled = False
        TimerDataLogRecord.Start()
    End Sub

    Private Sub ButtonStopRecording_Click(sender As Object, e As EventArgs) Handles ButtonStopRecording.Click
        ButtonStartRecording.Enabled = True
        ButtonStopRecording.Enabled = False
        ButtonSaveTOExcel.Enabled = True
        TimerDataLogRecord.Stop()
        PictureBoxRecordInd.Visible = True
    End Sub

    Private Sub ButtonSaveTOExcel_Click(sender As Object, e As EventArgs) Handles ButtonSaveTOExcel.Click
        ButtonSaveTOExcel.Height = 37
        ButtonSaveTOExcel.Text = "Please Wait..."
        ButtonSaveTOExcel.Enabled = False
        ButtonStartRecording.Enabled = False
        ProgressBarProcess.Visible = True
        ProgressBarProcess.Value = 1

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ProgressBarProcess.Value = 3

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        ProgressBarProcess.Value = 5

        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next

        ProgressBarProcess.Value = 8

        FilePathAndName = Application.StartupPath & "\" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xlsx"
        If File.Exists(FilePathAndName) Then File.Delete(FilePathAndName)

        xlWorkSheet.SaveAs(FilePathAndName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        ProgressBarProcess.Value = 10

        MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & FilePathAndName, MsgBoxStyle.Information, "Information")

        ProgressBarProcess.Visible = False

        Process.Start(FilePathAndName)

        ButtonSaveTOExcel.Height = 50
        ButtonSaveTOExcel.Text = "Save To MS Excel"
        ButtonSaveTOExcel.Enabled = True
        ButtonStartRecording.Enabled = True
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub TimerDataLogRecord_Tick(sender As Object, e As EventArgs) Handles TimerDataLogRecord.Tick
        Dim DT As DateTime = Now


        DataGridView1.Rows.Add(New String() {DataGridView1.RowCount, TempResult, HumResult, AltiResult, Dustresult, DT.ToLongTimeString, DT.ToString("dd-MM-yyyy"), Accex, Accey, Accez, X, Cal})
        Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1



        If PictureBoxRecordInd.Visible = True Then
            PictureBoxRecordInd.Visible = False
        ElseIf PictureBoxRecordInd.Visible = False Then
            PictureBoxRecordInd.Visible = True
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

    End Sub

    Dim StrSerialIn, StrSerialInRam, TemperatureS As String
    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data
    '------------------------------------------------
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GroupBox4.Hide()
        GroupBox5.Hide()
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        Me.CenterToScreen()
        PanelConnection.Focus()
        CircularProgressBarHumidity.Value = 0

        ComboBoxBaudRate.SelectedIndex = 0

        For i = 0 To 30 Step 1
            Chart1.Series("Temperature").Points.AddY(0)
            If Chart1.Series(0).Points.Count = ChartLimit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If

            Chart2.Series("Humidity").Points.AddY(0)
            If Chart2.Series(0).Points.Count = ChartLimit Then
                Chart2.Series(0).Points.RemoveAt(0)
            End If

            Chart3.Series("Altitude").Points.AddY(0)
            If Chart3.Series(0).Points.Count = ChartLimit Then
                Chart3.Series(0).Points.RemoveAt(0)
            End If
            ' Chart4.Series("Pressure").Points.AddY(0)
            ' If Chart4.Series(0).Points.Count = ChartLimit Then
            'Chart4.Series(0).Points.RemoveAt(0)
            ' End If



        Next

        Chart2.ChartAreas(0).AxisY.Maximum = 100
        Chart2.ChartAreas(0).AxisY.Minimum = -10
        Chart2.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False

        Chart1.ChartAreas(0).AxisY.Maximum = 70
        Chart1.ChartAreas(0).AxisY.Minimum = -30
        Chart1.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False

        Chart3.ChartAreas(0).AxisY.Maximum = 1550
        Chart3.ChartAreas(0).AxisY.Minimum = 1300
        Chart3.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False

        ' Chart4.ChartAreas(0).AxisY.Maximum = 70000
        ' Chart4.ChartAreas(0).AxisY.Minimum = 90000
        'Chart4.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False

        'PictureBoxPBTemp.Height = 0



    End Sub
    '------------------------------------------------
    Private Sub ComboBoxPort_Click(sender As System.Object, e As System.EventArgs)
    End Sub
    '------------------------------------------------


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        SerialPort1.Close()
        ButtonConnect.Enabled = True

    End Sub

    Private Sub ButtonConnect_Click_1(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        'SerialPort1.PortName = ComboBoxPort.Text
        'SerialPort1.BaudRate = ComboBoxBaudRate.Text
        ' SerialPort1.Open()
        'ButtonConnect.Enabled = False


        PanelConnection.Focus()
        Try
            SerialPort1.BaudRate = ComboBoxBaudRate.Text
            SerialPort1.PortName = ComboBoxPort.Text
            SerialPort1.Open()
            Timer.Start()

            LabelStatus.Text = "Status : Connected"
            ButtonConnect.SendToBack()
            ButtonDisconnect.BringToFront()
            PictureBoxStatusConnection.BackColor = Color.Green
        Catch ex As Exception
            MsgBox("Please check the Hardware, COM, Baud Rate and try again.", MsgBoxStyle.Critical, "Connection failed !!!")
        End Try
    End Sub
    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        PanelConnection.Focus()
        Timer.Stop()
        SerialPort1.Close()
        ButtonDisconnect.SendToBack()
        ButtonConnect.BringToFront()
        LabelStatus.Text = "Status : Disconnect"
        PictureBoxStatusConnection.Visible = True
        PictureBoxStatusConnection.BackColor = Color.Red

    End Sub
    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        PanelConnection.Focus()
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Conncetion in progress, please Disconnect to scan the new port.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
            ButtonConnect.Enabled = True
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Warning !!!")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub
    Function MapVPB(ByVal X As Single, ByVal In_min As Single, ByVal In_max As Single, ByVal Out_min As Single, ByVal Out_max As Single) As Integer
        Dim A As Single
        Dim B As Single
        A = X - In_min
        B = Out_max - Out_min
        A = A * B
        B = In_max - In_min
        A = A / B
        MapVPB = A + Out_min
    End Function
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick



        Try
            Dim StrSerialIn As String = SerialPort1.ReadExisting
            Dim StrSerialInRam As String

            Dim TB As New TextBox
            TB.Multiline = True
            TB.Text = StrSerialIn

            StrSerialInRam = TB.Lines(0).Substring(0, 2)
            If StrSerialInRam = "H1" Then
                Hum = TB.Lines(0)
                HumL = Hum.Length
            Else
                Hum = Hum
            End If

            StrSerialInRam = TB.Lines(1).Substring(0, 2)
            If StrSerialInRam = "A2" Then
                Alti = TB.Lines(1)
                AltiL = Alti.Length
            Else
                Alti = Alti
            End If

            StrSerialInRam = TB.Lines(2).Substring(0, 2)
            If StrSerialInRam = "T3" Then
                Temp = TB.Lines(2)
                TempL = Temp.Length
            Else
                Temp = Temp
            End If
            StrSerialInRam = TB.Lines(3).Substring(0, 2)
            If StrSerialInRam = "D1" Then
                Dust = TB.Lines(3)
                DustL = Dust.Length
            Else
                Dust = Dust
            End If
            StrSerialInRam = TB.Lines(4).Substring(0, 2)
            If StrSerialInRam = "X1" Then
                Axx = TB.Lines(4)
                AxxL = Axx.Length
            Else
                Axx = Axx
            End If
            StrSerialInRam = TB.Lines(5).Substring(0, 2)
            If StrSerialInRam = "Y1" Then
                Ayy = TB.Lines(5)
                AyyL = Ayy.Length
            Else
                Ayy = Ayy
            End If
            StrSerialInRam = TB.Lines(6).Substring(0, 2)
            If StrSerialInRam = "Z1" Then
                Azz = TB.Lines(6)
                AzzL = Azz.Length
            Else
                Azz = Azz
            End If


            HumResult = Mid(Hum, 3, HumL)
            AltiResult = Mid(Alti, 3, AltiL)
            TempResult = Mid(Temp, 3, TempL)
            Dustresult = Mid(Dust, 3, DustL)
            Accex = Mid(Axx, 3, AxxL)
            Accey = Mid(Ayy, 3, AyyL)
            Accez = Mid(Azz, 3, AzzL)

            humidity = Convert.ToInt32(HumResult)
            altitude = Convert.ToInt32(AltiResult)
            temperature = Convert.ToInt32(TempResult)

            dustf = Convert.ToSingle(Dustresult)
            Label5.Text = dustf
            CircularProgressBarHumidity.Value = humidity
            CircularProgressBarHumidity.Text = CircularProgressBarHumidity.Value & " %"
            LabelTemperature.Text = temperature & " °C"
            Label3.Text = AltiResult & " m"
            TempToProgressBar = temperature
            Label15.Text = Accex
            Label16.Text = Accey
            Label19.Text = Accez



            Label21.Text = AltiResult
            Label26.Text = Accex
            Label22.Text = Accey
            Label24.Text = Accez


            Label37.Text = TempResult
            Label36.Text = HumResult
            Label35.Text = dustf

            '-----------The process for making a progress bar using a picturebox (Vertical progress bar)-----------
            vpb_sy = MapVPB(TempToProgressBar, -20.0, 60.0, 0, 120)
            If vpb_sy > 120 Then
                vpb_sy = 120
            End If
            If vpb_sy < 0 Then
                vpb_sy = 0
            End If
            PictureBoxPBTemp.Height = PictureBoxPBTempBack.Height * vpb_sy / 120
            vpb_ly = (PictureBoxPBTempBack.Height - vpb_sy) + PictureBoxPBTempBack.Location.Y
            PictureBoxPBTemp.Location = New Point(PictureBoxPBTemp.Location.X, vpb_ly)

            PictureBoxPBAlti.Height = altitude
            ' PictureBox1.Height = temperature
            Chart1.Series("Temperature").Points.AddY(temperature)
            If Chart1.Series(0).Points.Count = ChartLimit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If

            Chart2.Series("Humidity").Points.AddY(humidity)
            If Chart2.Series(0).Points.Count = ChartLimit Then
                Chart2.Series(0).Points.RemoveAt(0)
            End If
            Chart3.Series("Altitude").Points.AddY(altitude)
            If Chart3.Series(0).Points.Count = ChartLimit Then
                Chart3.Series(0).Points.RemoveAt(0)
            End If
            'Chart4.Series("Pressure").Points.AddY(dustf)
            'If Chart4.Series(0).Points.Count = ChartLimit Then
            'Chart4.Series(0).Points.RemoveAt(0)
            ' End If
        Catch ex As Exception

        End Try
    End Sub

End Class
