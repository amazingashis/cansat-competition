<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnSat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnSat))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PanelConnection = New System.Windows.Forms.Panel()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.LabelBaudRate = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.LabelConnectionTitle = New System.Windows.Forms.Label()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBoxStatusConnection = New System.Windows.Forms.PictureBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.PanelHumidity = New System.Windows.Forms.Panel()
        Me.CircularProgressBarHumidity = New CircularProgressBar.CircularProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelTemperature = New System.Windows.Forms.Panel()
        Me.PictureBoxPBTemp = New System.Windows.Forms.PictureBox()
        Me.LabelTempMin = New System.Windows.Forms.Label()
        Me.LabelTemperature = New System.Windows.Forms.Label()
        Me.LabelTempMax = New System.Windows.Forms.Label()
        Me.PictureBoxPBTempBack = New System.Windows.Forms.PictureBox()
        Me.LabelTemperatureTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBoxPBAlti = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPBAltiBack = New System.Windows.Forms.PictureBox()
        Me.LabelAltitude = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Info = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temperature_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Humidity_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altitude_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dust_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Az = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Export = New System.Windows.Forms.GroupBox()
        Me.ProgressBarProcess = New System.Windows.Forms.ProgressBar()
        Me.ButtonSaveTOExcel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBoxRecordInd = New System.Windows.Forms.PictureBox()
        Me.Clear = New System.Windows.Forms.Button()
        Me.ButtonStopRecording = New System.Windows.Forms.Button()
        Me.ButtonStartRecording = New System.Windows.Forms.Button()
        Me.TimerDataLogRecord = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Types = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelConnection.SuspendLayout()
        CType(Me.PictureBoxStatusConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHumidity.SuspendLayout()
        Me.PanelTemperature.SuspendLayout()
        CType(Me.PictureBoxPBTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPBTempBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxPBAlti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPBAltiBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Export.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM6"
        '
        'PanelConnection
        '
        Me.PanelConnection.BackColor = System.Drawing.Color.White
        Me.PanelConnection.Controls.Add(Me.ComboBoxBaudRate)
        Me.PanelConnection.Controls.Add(Me.LabelBaudRate)
        Me.PanelConnection.Controls.Add(Me.ComboBoxPort)
        Me.PanelConnection.Controls.Add(Me.LabelConnectionTitle)
        Me.PanelConnection.Controls.Add(Me.ButtonScanPort)
        Me.PanelConnection.Controls.Add(Me.ButtonConnect)
        Me.PanelConnection.Controls.Add(Me.ButtonDisconnect)
        Me.PanelConnection.Location = New System.Drawing.Point(12, 28)
        Me.PanelConnection.Name = "PanelConnection"
        Me.PanelConnection.Size = New System.Drawing.Size(485, 126)
        Me.PanelConnection.TabIndex = 9
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxBaudRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBaudRate.ForeColor = System.Drawing.Color.White
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(298, 44)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBaudRate.TabIndex = 4
        '
        'LabelBaudRate
        '
        Me.LabelBaudRate.AutoSize = True
        Me.LabelBaudRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBaudRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.LabelBaudRate.Location = New System.Drawing.Point(217, 48)
        Me.LabelBaudRate.Name = "LabelBaudRate"
        Me.LabelBaudRate.Size = New System.Drawing.Size(75, 13)
        Me.LabelBaudRate.TabIndex = 3
        Me.LabelBaudRate.Text = "Baud Rate :"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPort.ForeColor = System.Drawing.Color.White
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(90, 45)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPort.TabIndex = 2
        '
        'LabelConnectionTitle
        '
        Me.LabelConnectionTitle.AutoSize = True
        Me.LabelConnectionTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelConnectionTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConnectionTitle.ForeColor = System.Drawing.Color.MediumBlue
        Me.LabelConnectionTitle.Location = New System.Drawing.Point(155, 12)
        Me.LabelConnectionTitle.Name = "LabelConnectionTitle"
        Me.LabelConnectionTitle.Size = New System.Drawing.Size(100, 20)
        Me.LabelConnectionTitle.TabIndex = 1
        Me.LabelConnectionTitle.Text = "Connection"
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ButtonScanPort.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonScanPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ButtonScanPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ButtonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanPort.ForeColor = System.Drawing.Color.White
        Me.ButtonScanPort.Location = New System.Drawing.Point(9, 43)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(75, 23)
        Me.ButtonScanPort.TabIndex = 0
        Me.ButtonScanPort.Text = "Scan Port"
        Me.ButtonScanPort.UseVisualStyleBackColor = False
        '
        'ButtonConnect
        '
        Me.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.ForeColor = System.Drawing.Color.White
        Me.ButtonConnect.Location = New System.Drawing.Point(9, 83)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(410, 23)
        Me.ButtonConnect.TabIndex = 5
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ButtonDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ButtonDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ButtonDisconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDisconnect.ForeColor = System.Drawing.Color.White
        Me.ButtonDisconnect.Location = New System.Drawing.Point(9, 83)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(410, 23)
        Me.ButtonDisconnect.TabIndex = 1
        Me.ButtonDisconnect.Text = "Disconnect"
        Me.ButtonDisconnect.UseVisualStyleBackColor = False
        '
        'Timer
        '
        Me.Timer.Interval = 500
        '
        'PictureBoxStatusConnection
        '
        Me.PictureBoxStatusConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxStatusConnection.BackColor = System.Drawing.Color.Red
        Me.PictureBoxStatusConnection.Location = New System.Drawing.Point(112, 1136)
        Me.PictureBoxStatusConnection.Name = "PictureBoxStatusConnection"
        Me.PictureBoxStatusConnection.Size = New System.Drawing.Size(10, 12)
        Me.PictureBoxStatusConnection.TabIndex = 16
        Me.PictureBoxStatusConnection.TabStop = False
        '
        'LabelStatus
        '
        Me.LabelStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.LabelStatus.Location = New System.Drawing.Point(9, 1135)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(100, 13)
        Me.LabelStatus.TabIndex = 15
        Me.LabelStatus.Text = "Status : Disconnect"
        '
        'PanelHumidity
        '
        Me.PanelHumidity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelHumidity.BackColor = System.Drawing.Color.White
        Me.PanelHumidity.Controls.Add(Me.CircularProgressBarHumidity)
        Me.PanelHumidity.Controls.Add(Me.Label1)
        Me.PanelHumidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelHumidity.ForeColor = System.Drawing.Color.White
        Me.PanelHumidity.Location = New System.Drawing.Point(537, 28)
        Me.PanelHumidity.Name = "PanelHumidity"
        Me.PanelHumidity.Size = New System.Drawing.Size(200, 179)
        Me.PanelHumidity.TabIndex = 17
        '
        'CircularProgressBarHumidity
        '
        Me.CircularProgressBarHumidity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CircularProgressBarHumidity.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBarHumidity.AnimationSpeed = 500
        Me.CircularProgressBarHumidity.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBarHumidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBarHumidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CircularProgressBarHumidity.InnerColor = System.Drawing.Color.White
        Me.CircularProgressBarHumidity.InnerMargin = 2
        Me.CircularProgressBarHumidity.InnerWidth = -1
        Me.CircularProgressBarHumidity.Location = New System.Drawing.Point(35, 43)
        Me.CircularProgressBarHumidity.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBarHumidity.Name = "CircularProgressBarHumidity"
        Me.CircularProgressBarHumidity.OuterColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.CircularProgressBarHumidity.OuterMargin = -25
        Me.CircularProgressBarHumidity.OuterWidth = 26
        Me.CircularProgressBarHumidity.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CircularProgressBarHumidity.ProgressWidth = 25
        Me.CircularProgressBarHumidity.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBarHumidity.Size = New System.Drawing.Size(120, 120)
        Me.CircularProgressBarHumidity.StartAngle = 90
        Me.CircularProgressBarHumidity.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBarHumidity.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBarHumidity.SubscriptText = ""
        Me.CircularProgressBarHumidity.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBarHumidity.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBarHumidity.SuperscriptText = " "
        Me.CircularProgressBarHumidity.TabIndex = 18
        Me.CircularProgressBarHumidity.Text = "  00%"
        Me.CircularProgressBarHumidity.TextMargin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.CircularProgressBarHumidity.Value = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(48, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Humidity"
        '
        'PanelTemperature
        '
        Me.PanelTemperature.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTemperature.BackColor = System.Drawing.Color.White
        Me.PanelTemperature.Controls.Add(Me.PictureBoxPBTemp)
        Me.PanelTemperature.Controls.Add(Me.LabelTempMin)
        Me.PanelTemperature.Controls.Add(Me.LabelTemperature)
        Me.PanelTemperature.Controls.Add(Me.LabelTempMax)
        Me.PanelTemperature.Controls.Add(Me.PictureBoxPBTempBack)
        Me.PanelTemperature.Controls.Add(Me.LabelTemperatureTitle)
        Me.PanelTemperature.Location = New System.Drawing.Point(537, 213)
        Me.PanelTemperature.Name = "PanelTemperature"
        Me.PanelTemperature.Size = New System.Drawing.Size(200, 176)
        Me.PanelTemperature.TabIndex = 18
        '
        'PictureBoxPBTemp
        '
        Me.PictureBoxPBTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBoxPBTemp.Location = New System.Drawing.Point(47, 62)
        Me.PictureBoxPBTemp.Name = "PictureBoxPBTemp"
        Me.PictureBoxPBTemp.Size = New System.Drawing.Size(27, 111)
        Me.PictureBoxPBTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPBTemp.TabIndex = 2
        Me.PictureBoxPBTemp.TabStop = False
        '
        'LabelTempMin
        '
        Me.LabelTempMin.AutoSize = True
        Me.LabelTempMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTempMin.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelTempMin.Location = New System.Drawing.Point(81, 152)
        Me.LabelTempMin.Name = "LabelTempMin"
        Me.LabelTempMin.Size = New System.Drawing.Size(22, 13)
        Me.LabelTempMin.TabIndex = 5
        Me.LabelTempMin.Text = "-10"
        '
        'LabelTemperature
        '
        Me.LabelTemperature.AutoSize = True
        Me.LabelTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTemperature.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelTemperature.Location = New System.Drawing.Point(80, 96)
        Me.LabelTemperature.Name = "LabelTemperature"
        Me.LabelTemperature.Size = New System.Drawing.Size(79, 31)
        Me.LabelTemperature.TabIndex = 4
        Me.LabelTemperature.Text = "00°C"
        '
        'LabelTempMax
        '
        Me.LabelTempMax.AutoSize = True
        Me.LabelTempMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTempMax.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelTempMax.Location = New System.Drawing.Point(81, 46)
        Me.LabelTempMax.Name = "LabelTempMax"
        Me.LabelTempMax.Size = New System.Drawing.Size(19, 13)
        Me.LabelTempMax.TabIndex = 3
        Me.LabelTempMax.Text = "60"
        '
        'PictureBoxPBTempBack
        '
        Me.PictureBoxPBTempBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.PictureBoxPBTempBack.Location = New System.Drawing.Point(47, 45)
        Me.PictureBoxPBTempBack.Name = "PictureBoxPBTempBack"
        Me.PictureBoxPBTempBack.Size = New System.Drawing.Size(27, 120)
        Me.PictureBoxPBTempBack.TabIndex = 1
        Me.PictureBoxPBTempBack.TabStop = False
        '
        'LabelTemperatureTitle
        '
        Me.LabelTemperatureTitle.AutoSize = True
        Me.LabelTemperatureTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTemperatureTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelTemperatureTitle.Location = New System.Drawing.Point(45, 11)
        Me.LabelTemperatureTitle.Name = "LabelTemperatureTitle"
        Me.LabelTemperatureTitle.Size = New System.Drawing.Size(111, 20)
        Me.LabelTemperatureTitle.TabIndex = 0
        Me.LabelTemperatureTitle.Text = "Temperature"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBoxPBAlti)
        Me.Panel1.Controls.Add(Me.PictureBoxPBAltiBack)
        Me.Panel1.Controls.Add(Me.LabelAltitude)
        Me.Panel1.Location = New System.Drawing.Point(537, 395)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 176)
        Me.Panel1.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(81, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "1400"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(80, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(81, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "1550"
        '
        'PictureBoxPBAlti
        '
        Me.PictureBoxPBAlti.BackColor = System.Drawing.Color.Green
        Me.PictureBoxPBAlti.Location = New System.Drawing.Point(47, 62)
        Me.PictureBoxPBAlti.Name = "PictureBoxPBAlti"
        Me.PictureBoxPBAlti.Size = New System.Drawing.Size(27, 103)
        Me.PictureBoxPBAlti.TabIndex = 2
        Me.PictureBoxPBAlti.TabStop = False
        '
        'PictureBoxPBAltiBack
        '
        Me.PictureBoxPBAltiBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.PictureBoxPBAltiBack.Location = New System.Drawing.Point(47, 45)
        Me.PictureBoxPBAltiBack.Name = "PictureBoxPBAltiBack"
        Me.PictureBoxPBAltiBack.Size = New System.Drawing.Size(27, 120)
        Me.PictureBoxPBAltiBack.TabIndex = 1
        Me.PictureBoxPBAltiBack.TabStop = False
        '
        'LabelAltitude
        '
        Me.LabelAltitude.AutoSize = True
        Me.LabelAltitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAltitude.ForeColor = System.Drawing.Color.Green
        Me.LabelAltitude.Location = New System.Drawing.Point(45, 11)
        Me.LabelAltitude.Name = "LabelAltitude"
        Me.LabelAltitude.Size = New System.Drawing.Size(71, 20)
        Me.LabelAltitude.TabIndex = 0
        Me.LabelAltitude.Text = "Altitude"
        '
        'Chart2
        '
        Me.Chart2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea7.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea7.BorderColor = System.Drawing.Color.BlueViolet
        ChartArea7.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea7)
        Legend7.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend7)
        Me.Chart2.Location = New System.Drawing.Point(772, 28)
        Me.Chart2.Margin = New System.Windows.Forms.Padding(4)
        Me.Chart2.Name = "Chart2"
        Series7.BorderWidth = 3
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series7.Color = System.Drawing.Color.Blue
        Series7.Legend = "Legend1"
        Series7.Name = "Humidity"
        Me.Chart2.Series.Add(Series7)
        Me.Chart2.Size = New System.Drawing.Size(587, 179)
        Me.Chart2.TabIndex = 26
        Me.Chart2.Text = "Chart2"
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea8.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea8.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea8.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend8)
        Me.Chart1.Location = New System.Drawing.Point(772, 217)
        Me.Chart1.Name = "Chart1"
        Series8.BorderWidth = 3
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series8.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Series8.LabelForeColor = System.Drawing.Color.BlanchedAlmond
        Series8.Legend = "Legend1"
        Series8.MarkerBorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Series8.Name = "Temperature"
        Me.Chart1.Series.Add(Series8)
        Me.Chart1.Size = New System.Drawing.Size(587, 172)
        Me.Chart1.TabIndex = 28
        Me.Chart1.Text = "Chart1"
        '
        'Chart3
        '
        Me.Chart3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea9.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea9.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        ChartArea9.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea9)
        Legend9.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend9)
        Me.Chart3.Location = New System.Drawing.Point(772, 392)
        Me.Chart3.Name = "Chart3"
        Series9.BorderWidth = 3
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series9.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series9.LabelForeColor = System.Drawing.Color.BlanchedAlmond
        Series9.Legend = "Legend1"
        Series9.MarkerBorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Series9.Name = "Altitude"
        Me.Chart3.Series.Add(Series9)
        Me.Chart3.Size = New System.Drawing.Size(587, 172)
        Me.Chart3.TabIndex = 29
        Me.Chart3.Text = "Chart3"
        '
        'PictureBox11
        '
        Me.PictureBox11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(1242, 73)
        Me.PictureBox11.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(117, 115)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 30
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox10.BackColor = System.Drawing.Color.White
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(1232, 259)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(123, 120)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 31
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox9.BackColor = System.Drawing.Color.White
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(1232, 431)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(123, 115)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 32
        Me.PictureBox9.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(1585, 1020)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(127, 124)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 33
        Me.PictureBox7.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 169)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(485, 171)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'Info
        '
        Me.Info.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Info.AutoSize = True
        Me.Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Info.Location = New System.Drawing.Point(614, 1120)
        Me.Info.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(414, 24)
        Me.Info.TabIndex = 34
        Me.Info.Text = "काठमाडौं विश्वविद्यालय।  वास्तविक समय डाटा निगरानी प्रणाली।"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1376, 866)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(561, 953)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(414, 24)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "काठमाडौं विश्वविद्यालय।  वास्तविक समय डाटा निगरानी प्रणाली।"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label10.Location = New System.Drawing.Point(18, 964)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Status : Disconnect"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.Color.Red
        Me.PictureBox4.Location = New System.Drawing.Point(126, 964)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(13, 15)
        Me.PictureBox4.TabIndex = 39
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(677, 597)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 31)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(531, 597)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 31)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Pressure:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 445)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 228)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Grid View (Real-Time/Second)"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Temperature_, Me.Humidity_, Me.Altitude_, Me.Dust_, Me.Time_, Me.Date_, Me.Ax, Me.Ay, Me.Az, Me.Types, Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(484, 203)
        Me.DataGridView1.TabIndex = 0
        '
        'No
        '
        Me.No.FillWeight = 55.18705!
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        '
        'Temperature_
        '
        Me.Temperature_.FillWeight = 135.0254!
        Me.Temperature_.HeaderText = "Temperature"
        Me.Temperature_.Name = "Temperature_"
        '
        'Humidity_
        '
        Me.Humidity_.FillWeight = 85.85979!
        Me.Humidity_.HeaderText = "Humdity"
        Me.Humidity_.Name = "Humidity_"
        '
        'Altitude_
        '
        Me.Altitude_.FillWeight = 89.12637!
        Me.Altitude_.HeaderText = "Altitude"
        Me.Altitude_.Name = "Altitude_"
        '
        'Dust_
        '
        Me.Dust_.FillWeight = 111.6005!
        Me.Dust_.HeaderText = "Pressure"
        Me.Dust_.Name = "Dust_"
        '
        'Time_
        '
        Me.Time_.FillWeight = 111.6005!
        Me.Time_.HeaderText = "Time"
        Me.Time_.Name = "Time_"
        '
        'Date_
        '
        Me.Date_.FillWeight = 111.6005!
        Me.Date_.HeaderText = "Date"
        Me.Date_.Name = "Date_"
        '
        'Ax
        '
        Me.Ax.HeaderText = "Ax"
        Me.Ax.Name = "Ax"
        '
        'Ay
        '
        Me.Ay.HeaderText = "Ay"
        Me.Ay.Name = "Ay"
        '
        'Az
        '
        Me.Az.HeaderText = "Az"
        Me.Az.Name = "Az"
        '
        'Export
        '
        Me.Export.BackColor = System.Drawing.Color.White
        Me.Export.Controls.Add(Me.ProgressBarProcess)
        Me.Export.Controls.Add(Me.ButtonSaveTOExcel)
        Me.Export.Location = New System.Drawing.Point(303, 346)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(194, 87)
        Me.Export.TabIndex = 51
        Me.Export.TabStop = False
        Me.Export.Text = "Export"
        '
        'ProgressBarProcess
        '
        Me.ProgressBarProcess.Location = New System.Drawing.Point(6, 67)
        Me.ProgressBarProcess.Maximum = 10
        Me.ProgressBarProcess.Name = "ProgressBarProcess"
        Me.ProgressBarProcess.Size = New System.Drawing.Size(166, 10)
        Me.ProgressBarProcess.TabIndex = 42
        '
        'ButtonSaveTOExcel
        '
        Me.ButtonSaveTOExcel.Location = New System.Drawing.Point(6, 19)
        Me.ButtonSaveTOExcel.Name = "ButtonSaveTOExcel"
        Me.ButtonSaveTOExcel.Size = New System.Drawing.Size(166, 39)
        Me.ButtonSaveTOExcel.TabIndex = 43
        Me.ButtonSaveTOExcel.Text = "Save to Ms Excel"
        Me.ButtonSaveTOExcel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.PictureBoxRecordInd)
        Me.GroupBox1.Controls.Add(Me.Clear)
        Me.GroupBox1.Controls.Add(Me.ButtonStopRecording)
        Me.GroupBox1.Controls.Add(Me.ButtonStartRecording)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 346)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 87)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(153, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Recording :"
        '
        'PictureBoxRecordInd
        '
        Me.PictureBoxRecordInd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxRecordInd.BackColor = System.Drawing.Color.Red
        Me.PictureBoxRecordInd.Location = New System.Drawing.Point(218, 3)
        Me.PictureBoxRecordInd.Name = "PictureBoxRecordInd"
        Me.PictureBoxRecordInd.Size = New System.Drawing.Size(10, 12)
        Me.PictureBoxRecordInd.TabIndex = 41
        Me.PictureBoxRecordInd.TabStop = False
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(8, 52)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(248, 27)
        Me.Clear.TabIndex = 2
        Me.Clear.Text = "Clear Data Grid View"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'ButtonStopRecording
        '
        Me.ButtonStopRecording.Location = New System.Drawing.Point(141, 19)
        Me.ButtonStopRecording.Name = "ButtonStopRecording"
        Me.ButtonStopRecording.Size = New System.Drawing.Size(115, 27)
        Me.ButtonStopRecording.TabIndex = 1
        Me.ButtonStopRecording.Text = "Stop recording"
        Me.ButtonStopRecording.UseVisualStyleBackColor = True
        '
        'ButtonStartRecording
        '
        Me.ButtonStartRecording.Location = New System.Drawing.Point(6, 19)
        Me.ButtonStartRecording.Name = "ButtonStartRecording"
        Me.ButtonStartRecording.Size = New System.Drawing.Size(129, 27)
        Me.ButtonStartRecording.TabIndex = 0
        Me.ButtonStartRecording.Text = "Start Recording"
        Me.ButtonStartRecording.UseVisualStyleBackColor = True
        '
        'TimerDataLogRecord
        '
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(887, 570)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(472, 73)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acceleration"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(394, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 29)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(234, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 29)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(80, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 29)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(173, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 29)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Az :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(343, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 29)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Az :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(19, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 29)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Ax :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(776, 596)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 31)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Pascal"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(21, 696)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1322, 50)
        Me.GroupBox4.TabIndex = 56
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data During Decend :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(127, 20)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(22, 18)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "m"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(210, 20)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(26, 18)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "00"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(166, 20)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(36, 18)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Ax :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(433, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(26, 18)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(269, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 18)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Ay :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(311, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(26, 18)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "00"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(380, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 18)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Az :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(85, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(26, 18)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Altitude :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label40)
        Me.GroupBox5.Controls.Add(Me.Label39)
        Me.GroupBox5.Controls.Add(Me.Label38)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(21, 769)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1322, 50)
        Me.GroupBox5.TabIndex = 57
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data At Lunar Zone :"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(611, 20)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(57, 18)
        Me.Label40.TabIndex = 16
        Me.Label40.Text = "pascal"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(343, 20)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(22, 18)
        Me.Label39.TabIndex = 15
        Me.Label39.Text = "%"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(167, 20)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(27, 18)
        Me.Label38.TabIndex = 14
        Me.Label38.Text = "*C"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(550, 20)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 18)
        Me.Label35.TabIndex = 11
        Me.Label35.Text = "00000"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(311, 20)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(26, 18)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "00"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(127, 20)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(26, 18)
        Me.Label37.TabIndex = 13
        Me.Label37.Text = "00"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(471, 20)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(86, 18)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = "Pressure :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(232, 20)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(83, 18)
        Me.Label33.TabIndex = 12
        Me.Label33.Text = "Humidity :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(9, 20)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(113, 18)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "Temperature :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(621, 649)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 34)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Data During Decend"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(877, 649)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(238, 34)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Data At Lunar Zone "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Types
        '
        Me.Types.HeaderText = "Type"
        Me.Types.Name = "Types"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Call Sign"
        Me.Column1.Name = "Column1"
        '
        'EnSat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1388, 845)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Export)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Info)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTemperature)
        Me.Controls.Add(Me.PanelHumidity)
        Me.Controls.Add(Me.PictureBoxStatusConnection)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PanelConnection)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "EnSat"
        Me.Text = "EnSat"
        Me.PanelConnection.ResumeLayout(False)
        Me.PanelConnection.PerformLayout()
        CType(Me.PictureBoxStatusConnection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHumidity.ResumeLayout(False)
        Me.PanelHumidity.PerformLayout()
        Me.PanelTemperature.ResumeLayout(False)
        Me.PanelTemperature.PerformLayout()
        CType(Me.PictureBoxPBTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPBTempBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxPBAlti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPBAltiBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Export.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents PanelConnection As Panel
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents LabelBaudRate As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents LabelConnectionTitle As Label
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents PictureBoxStatusConnection As PictureBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents PanelHumidity As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CircularProgressBarHumidity As CircularProgressBar.CircularProgressBar
    Friend WithEvents PanelTemperature As Panel
    Friend WithEvents LabelTempMin As Label
    Friend WithEvents LabelTemperature As Label
    Friend WithEvents LabelTempMax As Label
    Friend WithEvents PictureBoxPBTempBack As PictureBox
    Friend WithEvents LabelTemperatureTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBoxPBAlti As PictureBox
    Friend WithEvents PictureBoxPBAltiBack As PictureBox
    Friend WithEvents LabelAltitude As Label
    Friend WithEvents PictureBoxPBTemp As PictureBox
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Info As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Export As GroupBox
    Friend WithEvents ProgressBarProcess As ProgressBar
    Friend WithEvents ButtonSaveTOExcel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBoxRecordInd As PictureBox
    Friend WithEvents Clear As Button
    Friend WithEvents ButtonStopRecording As Button
    Friend WithEvents ButtonStartRecording As Button
    Friend WithEvents TimerDataLogRecord As Timer
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Temperature_ As DataGridViewTextBoxColumn
    Friend WithEvents Humidity_ As DataGridViewTextBoxColumn
    Friend WithEvents Altitude_ As DataGridViewTextBoxColumn
    Friend WithEvents Dust_ As DataGridViewTextBoxColumn
    Friend WithEvents Time_ As DataGridViewTextBoxColumn
    Friend WithEvents Date_ As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Ax As DataGridViewTextBoxColumn
    Friend WithEvents Ay As DataGridViewTextBoxColumn
    Friend WithEvents Az As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Types As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
