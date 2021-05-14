<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
	Inherits System.Windows.Forms.Form

	'Форма переопределяет dispose для очистки списка компонентов.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Является обязательной для конструктора форм Windows Forms
	Private components As System.ComponentModel.IContainer

	'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
	'Для ее изменения используйте конструктор форм Windows Form.  
	'Не изменяйте ее в редакторе исходного кода.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
		Me.TrayControl = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.TSMI_Enable = New System.Windows.Forms.ToolStripMenuItem()
		Me.TSMI_Disable = New System.Windows.Forms.ToolStripMenuItem()
		Me.TSMI_Settings = New System.Windows.Forms.ToolStripMenuItem()
		Me.TSMI_Close = New System.Windows.Forms.ToolStripMenuItem()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.FLP_Custom = New System.Windows.Forms.FlowLayoutPanel()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.CheckBox3 = New System.Windows.Forms.CheckBox()
		Me.CheckBox4 = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.CB = New System.Windows.Forms.CheckBox()
		Me.NUD_F = New System.Windows.Forms.NumericUpDown()
		Me.LB = New System.Windows.Forms.Label()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.CheckBox5 = New System.Windows.Forms.CheckBox()
		Me.HUD_K = New System.Windows.Forms.NumericUpDown()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.CheckBox7 = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
		Me.CheckBox6 = New System.Windows.Forms.CheckBox()
		Me.NUD_E = New System.Windows.Forms.NumericUpDown()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.CheckBox8 = New System.Windows.Forms.CheckBox()
		Me.CheckBox9 = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.DNS_IP = New System.Windows.Forms.TextBox()
		Me.DNS_Port = New System.Windows.Forms.TextBox()
		Me.CB_DNS = New System.Windows.Forms.CheckBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.DNS6_IP = New System.Windows.Forms.TextBox()
		Me.DNS6_Port = New System.Windows.Forms.TextBox()
		Me.CB_DNS6 = New System.Windows.Forms.CheckBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
		Me.CheckBox12 = New System.Windows.Forms.CheckBox()
		Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.CheckBox10 = New System.Windows.Forms.CheckBox()
		Me.FLP_Radio = New System.Windows.Forms.FlowLayoutPanel()
		Me.RB_Custom = New System.Windows.Forms.RadioButton()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.RB_P1 = New System.Windows.Forms.RadioButton()
		Me.RB_P2 = New System.Windows.Forms.RadioButton()
		Me.RB_P3 = New System.Windows.Forms.RadioButton()
		Me.RB_P4 = New System.Windows.Forms.RadioButton()
		Me.B_Stop = New System.Windows.Forms.Button()
		Me.B_Start = New System.Windows.Forms.Button()
		Me.B_Copy = New System.Windows.Forms.Button()
		Me.TLP_Buttons = New System.Windows.Forms.TableLayoutPanel()
		Me.FormMenu = New System.Windows.Forms.MenuStrip()
		Me.TraySettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TSMI_Mini = New System.Windows.Forms.ToolStripMenuItem()
		Me.TSMI_Start = New System.Windows.Forms.ToolStripMenuItem()
		Me.TSMI_Logon = New System.Windows.Forms.ToolStripMenuItem()
		Me.ListsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TSMI_Blacklist = New System.Windows.Forms.ToolStripMenuItem()
		Me.TSMI_Userlist = New System.Windows.Forms.ToolStripMenuItem()
		Me.TSMI_Debug = New System.Windows.Forms.ToolStripMenuItem()
		Me.TLP_S = New System.Windows.Forms.TableLayoutPanel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.CB_Blacklist = New System.Windows.Forms.CheckBox()
		Me.CB_Userlist = New System.Windows.Forms.CheckBox()
		Me.BS_ControlSettings = New System.Windows.Forms.BindingSource(Me.components)
		Me.BS_GDPISettings = New System.Windows.Forms.BindingSource(Me.components)
		Me.TrayMenu.SuspendLayout()
		Me.FLP_Custom.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		CType(Me.NUD_F, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel4.SuspendLayout()
		CType(Me.HUD_K, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel5.SuspendLayout()
		CType(Me.NUD_E, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.TableLayoutPanel7.SuspendLayout()
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FLP_Radio.SuspendLayout()
		Me.TLP_Buttons.SuspendLayout()
		Me.FormMenu.SuspendLayout()
		Me.TLP_S.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.FlowLayoutPanel2.SuspendLayout()
		CType(Me.BS_ControlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BS_GDPISettings, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TrayControl
		'
		Me.TrayControl.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.TrayControl.ContextMenuStrip = Me.TrayMenu
		Me.TrayControl.Icon = CType(resources.GetObject("TrayControl.Icon"), System.Drawing.Icon)
		Me.TrayControl.Text = "GDPI Control"
		Me.TrayControl.Visible = True
		'
		'TrayMenu
		'
		Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_Enable, Me.TSMI_Disable, Me.TSMI_Settings, Me.TSMI_Close})
		Me.TrayMenu.Name = "TrayMenu"
		Me.TrayMenu.Size = New System.Drawing.Size(142, 92)
		'
		'TSMI_Enable
		'
		Me.TSMI_Enable.Name = "TSMI_Enable"
		Me.TSMI_Enable.Size = New System.Drawing.Size(141, 22)
		Me.TSMI_Enable.Text = "Enable GDPI"
		'
		'TSMI_Disable
		'
		Me.TSMI_Disable.Name = "TSMI_Disable"
		Me.TSMI_Disable.Size = New System.Drawing.Size(141, 22)
		Me.TSMI_Disable.Text = "Disable GDPI"
		'
		'TSMI_Settings
		'
		Me.TSMI_Settings.Name = "TSMI_Settings"
		Me.TSMI_Settings.Size = New System.Drawing.Size(141, 22)
		Me.TSMI_Settings.Text = "Settings"
		'
		'TSMI_Close
		'
		Me.TSMI_Close.Name = "TSMI_Close"
		Me.TSMI_Close.Size = New System.Drawing.Size(141, 22)
		Me.TSMI_Close.Text = "Close"
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "P", True))
		Me.CheckBox1.Location = New System.Drawing.Point(8, 8)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CheckBox1.Size = New System.Drawing.Size(128, 17)
		Me.CheckBox1.TabIndex = 1
		Me.CheckBox1.Text = "-p Block passive DPI"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'FLP_Custom
		'
		Me.FLP_Custom.AutoSize = True
		Me.FLP_Custom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FLP_Custom.Controls.Add(Me.CheckBox1)
		Me.FLP_Custom.Controls.Add(Me.CheckBox2)
		Me.FLP_Custom.Controls.Add(Me.CheckBox3)
		Me.FLP_Custom.Controls.Add(Me.CheckBox4)
		Me.FLP_Custom.Controls.Add(Me.TableLayoutPanel3)
		Me.FLP_Custom.Controls.Add(Me.TableLayoutPanel4)
		Me.FLP_Custom.Controls.Add(Me.CheckBox7)
		Me.FLP_Custom.Controls.Add(Me.TableLayoutPanel5)
		Me.FLP_Custom.Controls.Add(Me.CheckBox8)
		Me.FLP_Custom.Controls.Add(Me.CheckBox9)
		Me.FLP_Custom.Controls.Add(Me.TableLayoutPanel1)
		Me.FLP_Custom.Controls.Add(Me.TableLayoutPanel2)
		Me.FLP_Custom.Controls.Add(Me.TableLayoutPanel7)
		Me.FLP_Custom.Controls.Add(Me.CheckBox10)
		Me.FLP_Custom.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FLP_Custom.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FLP_Custom.Location = New System.Drawing.Point(3, 3)
		Me.FLP_Custom.Name = "FLP_Custom"
		Me.FLP_Custom.Padding = New System.Windows.Forms.Padding(5)
		Me.FLP_Custom.Size = New System.Drawing.Size(468, 386)
		Me.FLP_Custom.TabIndex = 5
		'
		'CheckBox2
		'
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "R", True))
		Me.CheckBox2.Location = New System.Drawing.Point(8, 31)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CheckBox2.Size = New System.Drawing.Size(150, 17)
		Me.CheckBox2.TabIndex = 2
		Me.CheckBox2.Text = "-r Replace Host with hoSt"
		Me.CheckBox2.UseVisualStyleBackColor = True
		'
		'CheckBox3
		'
		Me.CheckBox3.AutoSize = True
		Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "S", True))
		Me.CheckBox3.Location = New System.Drawing.Point(8, 54)
		Me.CheckBox3.Name = "CheckBox3"
		Me.CheckBox3.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CheckBox3.Size = New System.Drawing.Size(279, 17)
		Me.CheckBox3.TabIndex = 3
		Me.CheckBox3.Text = "-s Remove space between host header And its value"
		Me.CheckBox3.UseVisualStyleBackColor = True
		'
		'CheckBox4
		'
		Me.CheckBox4.AutoSize = True
		Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "M", True))
		Me.CheckBox4.Location = New System.Drawing.Point(8, 77)
		Me.CheckBox4.Name = "CheckBox4"
		Me.CheckBox4.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CheckBox4.Size = New System.Drawing.Size(257, 17)
		Me.CheckBox4.TabIndex = 4
		Me.CheckBox4.Text = "-m Mix Host header case (test.com -> tEsT.cOm)"
		Me.CheckBox4.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.AutoSize = True
		Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel3.ColumnCount = 3
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.CB, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.NUD_F, 1, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.LB, 2, 0)
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(8, 100)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(256, 26)
		Me.TableLayoutPanel3.TabIndex = 7
		'
		'CB
		'
		Me.CB.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.CB.AutoSize = True
		Me.CB.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "F_State", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CB.Location = New System.Drawing.Point(3, 6)
		Me.CB.Name = "CB"
		Me.CB.Size = New System.Drawing.Size(15, 14)
		Me.CB.TabIndex = 1
		Me.CB.UseVisualStyleBackColor = True
		'
		'NUD_F
		'
		Me.NUD_F.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_GDPISettings, "F_Value", True))
		Me.NUD_F.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.BS_GDPISettings, "F_State", True))
		Me.NUD_F.Location = New System.Drawing.Point(24, 3)
		Me.NUD_F.Name = "NUD_F"
		Me.NUD_F.Size = New System.Drawing.Size(51, 20)
		Me.NUD_F.TabIndex = 2
		'
		'LB
		'
		Me.LB.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.LB.AutoSize = True
		Me.LB.Location = New System.Drawing.Point(81, 6)
		Me.LB.Name = "LB"
		Me.LB.Size = New System.Drawing.Size(172, 13)
		Me.LB.TabIndex = 0
		Me.LB.Text = "-f Set HTTP fragmentation to value"
		'
		'TableLayoutPanel4
		'
		Me.TableLayoutPanel4.AutoSize = True
		Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel4.ColumnCount = 3
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel4.Controls.Add(Me.CheckBox5, 0, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.HUD_K, 1, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.Label3, 2, 0)
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(8, 132)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 1
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(428, 26)
		Me.TableLayoutPanel4.TabIndex = 8
		'
		'CheckBox5
		'
		Me.CheckBox5.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.CheckBox5.AutoSize = True
		Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "K_State", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CheckBox5.Location = New System.Drawing.Point(3, 6)
		Me.CheckBox5.Name = "CheckBox5"
		Me.CheckBox5.Size = New System.Drawing.Size(15, 14)
		Me.CheckBox5.TabIndex = 1
		Me.CheckBox5.UseVisualStyleBackColor = True
		'
		'HUD_K
		'
		Me.HUD_K.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.BS_GDPISettings, "K_State", True))
		Me.HUD_K.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_GDPISettings, "K_Value", True))
		Me.HUD_K.Location = New System.Drawing.Point(24, 3)
		Me.HUD_K.Name = "HUD_K"
		Me.HUD_K.Size = New System.Drawing.Size(51, 20)
		Me.HUD_K.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(81, 6)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(344, 13)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "-k Enable HTTP persistent (keep-alive) fragmentation and set it to value"
		'
		'CheckBox7
		'
		Me.CheckBox7.AutoSize = True
		Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "N", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CheckBox7.Location = New System.Drawing.Point(8, 164)
		Me.CheckBox7.Name = "CheckBox7"
		Me.CheckBox7.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CheckBox7.Size = New System.Drawing.Size(288, 17)
		Me.CheckBox7.TabIndex = 7
		Me.CheckBox7.Text = "-n Do not wait for first segment ACK when -k is enabled"
		Me.CheckBox7.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel5
		'
		Me.TableLayoutPanel5.AutoSize = True
		Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel5.ColumnCount = 3
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel5.Controls.Add(Me.CheckBox6, 0, 0)
		Me.TableLayoutPanel5.Controls.Add(Me.NUD_E, 1, 0)
		Me.TableLayoutPanel5.Controls.Add(Me.Label4, 2, 0)
		Me.TableLayoutPanel5.Location = New System.Drawing.Point(8, 187)
		Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
		Me.TableLayoutPanel5.RowCount = 1
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
		Me.TableLayoutPanel5.Size = New System.Drawing.Size(266, 26)
		Me.TableLayoutPanel5.TabIndex = 8
		'
		'CheckBox6
		'
		Me.CheckBox6.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.CheckBox6.AutoSize = True
		Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "E_State", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CheckBox6.Location = New System.Drawing.Point(3, 6)
		Me.CheckBox6.Name = "CheckBox6"
		Me.CheckBox6.Size = New System.Drawing.Size(15, 14)
		Me.CheckBox6.TabIndex = 1
		Me.CheckBox6.UseVisualStyleBackColor = True
		'
		'NUD_E
		'
		Me.NUD_E.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.BS_GDPISettings, "E_State", True))
		Me.NUD_E.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_GDPISettings, "E_Value", True))
		Me.NUD_E.Location = New System.Drawing.Point(24, 3)
		Me.NUD_E.Name = "NUD_E"
		Me.NUD_E.Size = New System.Drawing.Size(51, 20)
		Me.NUD_E.TabIndex = 2
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(81, 6)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(182, 13)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "-e Set HTTPS fragmentation to value"
		'
		'CheckBox8
		'
		Me.CheckBox8.AutoSize = True
		Me.CheckBox8.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "A", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CheckBox8.Location = New System.Drawing.Point(8, 219)
		Me.CheckBox8.Name = "CheckBox8"
		Me.CheckBox8.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CheckBox8.Size = New System.Drawing.Size(425, 17)
		Me.CheckBox8.TabIndex = 9
		Me.CheckBox8.Text = "-a Additional space between Method And Request-URI (enables -s, may break sites)"
		Me.CheckBox8.UseVisualStyleBackColor = True
		'
		'CheckBox9
		'
		Me.CheckBox9.AutoSize = True
		Me.CheckBox9.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "W", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CheckBox9.Location = New System.Drawing.Point(8, 242)
		Me.CheckBox9.Name = "CheckBox9"
		Me.CheckBox9.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CheckBox9.Size = New System.Drawing.Size(407, 17)
		Me.CheckBox9.TabIndex = 10
		Me.CheckBox9.Text = "-w Try to find And parse HTTP traffic on all processed ports (Not only on port 80" &
	")"
		Me.CheckBox9.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 4
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.DNS_IP, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.DNS_Port, 2, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.CB_DNS, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 3, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 265)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(452, 26)
		Me.TableLayoutPanel1.TabIndex = 7
		'
		'DNS_IP
		'
		Me.DNS_IP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_GDPISettings, "DNS_IP", True))
		Me.DNS_IP.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.BS_GDPISettings, "DNS_State", True))
		Me.DNS_IP.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DNS_IP.Location = New System.Drawing.Point(24, 3)
		Me.DNS_IP.Name = "DNS_IP"
		Me.DNS_IP.Size = New System.Drawing.Size(150, 20)
		Me.DNS_IP.TabIndex = 3
		'
		'DNS_Port
		'
		Me.DNS_Port.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_GDPISettings, "DNS_Port", True))
		Me.DNS_Port.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.BS_GDPISettings, "DNS_State", True))
		Me.DNS_Port.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DNS_Port.Location = New System.Drawing.Point(180, 3)
		Me.DNS_Port.MaxLength = 5
		Me.DNS_Port.Name = "DNS_Port"
		Me.DNS_Port.Size = New System.Drawing.Size(50, 20)
		Me.DNS_Port.TabIndex = 1
		'
		'CB_DNS
		'
		Me.CB_DNS.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.CB_DNS.AutoSize = True
		Me.CB_DNS.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "DNS_State", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CB_DNS.Location = New System.Drawing.Point(3, 6)
		Me.CB_DNS.Name = "CB_DNS"
		Me.CB_DNS.Size = New System.Drawing.Size(15, 14)
		Me.CB_DNS.TabIndex = 0
		Me.CB_DNS.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(236, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(175, 26)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Redirect UDP DNS requests to the supplied IP address:port"
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.AutoSize = True
		Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel2.ColumnCount = 4
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.DNS6_IP, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.DNS6_Port, 2, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.CB_DNS6, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Label2, 3, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(8, 297)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(452, 26)
		Me.TableLayoutPanel2.TabIndex = 8
		'
		'DNS6_IP
		'
		Me.DNS6_IP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_GDPISettings, "DNS6_IP", True))
		Me.DNS6_IP.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.BS_GDPISettings, "DNS6_State", True))
		Me.DNS6_IP.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DNS6_IP.Location = New System.Drawing.Point(24, 3)
		Me.DNS6_IP.Name = "DNS6_IP"
		Me.DNS6_IP.Size = New System.Drawing.Size(150, 20)
		Me.DNS6_IP.TabIndex = 3
		'
		'DNS6_Port
		'
		Me.DNS6_Port.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_GDPISettings, "DNS6_Port", True))
		Me.DNS6_Port.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.BS_GDPISettings, "DNS6_State", True))
		Me.DNS6_Port.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DNS6_Port.Location = New System.Drawing.Point(180, 3)
		Me.DNS6_Port.MaxLength = 5
		Me.DNS6_Port.Name = "DNS6_Port"
		Me.DNS6_Port.Size = New System.Drawing.Size(50, 20)
		Me.DNS6_Port.TabIndex = 1
		'
		'CB_DNS6
		'
		Me.CB_DNS6.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.CB_DNS6.AutoSize = True
		Me.CB_DNS6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "DNS6_State", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CB_DNS6.Location = New System.Drawing.Point(3, 6)
		Me.CB_DNS6.Name = "CB_DNS6"
		Me.CB_DNS6.Size = New System.Drawing.Size(15, 14)
		Me.CB_DNS6.TabIndex = 0
		Me.CB_DNS6.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(236, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(187, 26)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Redirect UDPv6 DNS requests to the supplied IPv6 address:port"
		'
		'TableLayoutPanel7
		'
		Me.TableLayoutPanel7.AutoSize = True
		Me.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel7.ColumnCount = 3
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel7.Controls.Add(Me.CheckBox12, 0, 0)
		Me.TableLayoutPanel7.Controls.Add(Me.NumericUpDown1, 1, 0)
		Me.TableLayoutPanel7.Controls.Add(Me.Label6, 2, 0)
		Me.TableLayoutPanel7.Location = New System.Drawing.Point(8, 329)
		Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
		Me.TableLayoutPanel7.RowCount = 1
		Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel7.Size = New System.Drawing.Size(435, 26)
		Me.TableLayoutPanel7.TabIndex = 13
		'
		'CheckBox12
		'
		Me.CheckBox12.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.CheckBox12.AutoSize = True
		Me.CheckBox12.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "TTL_State", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CheckBox12.Location = New System.Drawing.Point(3, 6)
		Me.CheckBox12.Name = "CheckBox12"
		Me.CheckBox12.Size = New System.Drawing.Size(15, 14)
		Me.CheckBox12.TabIndex = 1
		Me.CheckBox12.UseVisualStyleBackColor = True
		'
		'NumericUpDown1
		'
		Me.NumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_GDPISettings, "TTL_Value", True))
		Me.NumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.BS_GDPISettings, "TTL_State", True, System.Windows.Forms.DataSourceUpdateMode.Never))
		Me.NumericUpDown1.Location = New System.Drawing.Point(24, 3)
		Me.NumericUpDown1.Name = "NumericUpDown1"
		Me.NumericUpDown1.Size = New System.Drawing.Size(51, 20)
		Me.NumericUpDown1.TabIndex = 2
		'
		'Label6
		'
		Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(81, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(351, 26)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Activate Fake Request Mode And send it with supplied TTL value." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DANGEROUS! May b" &
	"reak websites In unexpected ways. Use With care."
		'
		'CheckBox10
		'
		Me.CheckBox10.AutoSize = True
		Me.CheckBox10.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "ChkSum", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.CheckBox10.Location = New System.Drawing.Point(8, 361)
		Me.CheckBox10.Name = "CheckBox10"
		Me.CheckBox10.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CheckBox10.Size = New System.Drawing.Size(369, 17)
		Me.CheckBox10.TabIndex = 11
		Me.CheckBox10.Text = "Activate Fake Request Mode And send it with incorrect TCP checksum."
		Me.CheckBox10.UseVisualStyleBackColor = True
		'
		'FLP_Radio
		'
		Me.FLP_Radio.AutoSize = True
		Me.FLP_Radio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FLP_Radio.Controls.Add(Me.RB_Custom)
		Me.FLP_Radio.Controls.Add(Me.Label5)
		Me.FLP_Radio.Controls.Add(Me.RB_P1)
		Me.FLP_Radio.Controls.Add(Me.RB_P2)
		Me.FLP_Radio.Controls.Add(Me.RB_P3)
		Me.FLP_Radio.Controls.Add(Me.RB_P4)
		Me.FLP_Radio.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FLP_Radio.Location = New System.Drawing.Point(3, 3)
		Me.FLP_Radio.Name = "FLP_Radio"
		Me.FLP_Radio.Size = New System.Drawing.Size(245, 128)
		Me.FLP_Radio.TabIndex = 8
		'
		'RB_Custom
		'
		Me.RB_Custom.AutoSize = True
		Me.RB_Custom.Checked = True
		Me.RB_Custom.Location = New System.Drawing.Point(3, 3)
		Me.RB_Custom.Name = "RB_Custom"
		Me.RB_Custom.Size = New System.Drawing.Size(86, 17)
		Me.RB_Custom.TabIndex = 7
		Me.RB_Custom.TabStop = True
		Me.RB_Custom.Text = "User settings"
		Me.RB_Custom.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(3, 23)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(97, 13)
		Me.Label5.TabIndex = 12
		Me.Label5.Text = "Predefined settings"
		'
		'RB_P1
		'
		Me.RB_P1.AutoSize = True
		Me.RB_P1.Location = New System.Drawing.Point(3, 39)
		Me.RB_P1.Name = "RB_P1"
		Me.RB_P1.Size = New System.Drawing.Size(181, 17)
		Me.RB_P1.TabIndex = 8
		Me.RB_P1.Text = "-1 Most compatible mode, default"
		Me.RB_P1.UseVisualStyleBackColor = True
		'
		'RB_P2
		'
		Me.RB_P2.AutoSize = True
		Me.RB_P2.Location = New System.Drawing.Point(3, 62)
		Me.RB_P2.Name = "RB_P2"
		Me.RB_P2.Size = New System.Drawing.Size(239, 17)
		Me.RB_P2.TabIndex = 9
		Me.RB_P2.Text = "-2 Better speed for HTTPS yet still compatible"
		Me.RB_P2.UseVisualStyleBackColor = True
		'
		'RB_P3
		'
		Me.RB_P3.AutoSize = True
		Me.RB_P3.Location = New System.Drawing.Point(3, 85)
		Me.RB_P3.Name = "RB_P3"
		Me.RB_P3.Size = New System.Drawing.Size(204, 17)
		Me.RB_P3.TabIndex = 10
		Me.RB_P3.Text = "-3 Better speed for HTTP and HTTPS"
		Me.RB_P3.UseVisualStyleBackColor = True
		'
		'RB_P4
		'
		Me.RB_P4.AutoSize = True
		Me.RB_P4.Location = New System.Drawing.Point(3, 108)
		Me.RB_P4.Name = "RB_P4"
		Me.RB_P4.Size = New System.Drawing.Size(90, 17)
		Me.RB_P4.TabIndex = 11
		Me.RB_P4.Text = "-4 Best speed"
		Me.RB_P4.UseVisualStyleBackColor = True
		'
		'B_Stop
		'
		Me.B_Stop.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.B_Stop.AutoSize = True
		Me.B_Stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Stop.Location = New System.Drawing.Point(376, 13)
		Me.B_Stop.Margin = New System.Windows.Forms.Padding(10)
		Me.B_Stop.Name = "B_Stop"
		Me.B_Stop.Size = New System.Drawing.Size(88, 23)
		Me.B_Stop.TabIndex = 2
		Me.B_Stop.Text = "Stop and close"
		Me.B_Stop.UseVisualStyleBackColor = True
		'
		'B_Start
		'
		Me.B_Start.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.B_Start.AutoSize = True
		Me.B_Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Start.Location = New System.Drawing.Point(213, 10)
		Me.B_Start.Margin = New System.Windows.Forms.Padding(10)
		Me.B_Start.Name = "B_Start"
		Me.B_Start.Padding = New System.Windows.Forms.Padding(3)
		Me.B_Start.Size = New System.Drawing.Size(74, 29)
		Me.B_Start.TabIndex = 1
		Me.B_Start.Text = "Start GDPI"
		Me.B_Start.UseVisualStyleBackColor = True
		'
		'B_Copy
		'
		Me.B_Copy.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.B_Copy.AutoSize = True
		Me.B_Copy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.B_Copy.Location = New System.Drawing.Point(10, 13)
		Me.B_Copy.Margin = New System.Windows.Forms.Padding(10)
		Me.B_Copy.Name = "B_Copy"
		Me.B_Copy.Size = New System.Drawing.Size(115, 23)
		Me.B_Copy.TabIndex = 0
		Me.B_Copy.Text = "Copy to user settings"
		Me.B_Copy.UseVisualStyleBackColor = True
		'
		'TLP_Buttons
		'
		Me.TLP_Buttons.AutoSize = True
		Me.TLP_Buttons.ColumnCount = 3
		Me.TLP_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TLP_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TLP_Buttons.Controls.Add(Me.B_Stop, 2, 0)
		Me.TLP_Buttons.Controls.Add(Me.B_Copy, 0, 0)
		Me.TLP_Buttons.Controls.Add(Me.B_Start, 1, 0)
		Me.TLP_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.TLP_Buttons.Location = New System.Drawing.Point(0, 563)
		Me.TLP_Buttons.Name = "TLP_Buttons"
		Me.TLP_Buttons.RowCount = 1
		Me.TLP_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Buttons.Size = New System.Drawing.Size(474, 49)
		Me.TLP_Buttons.TabIndex = 3
		'
		'FormMenu
		'
		Me.FormMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TraySettingsToolStripMenuItem, Me.ListsToolStripMenuItem, Me.TSMI_Debug})
		Me.FormMenu.Location = New System.Drawing.Point(0, 0)
		Me.FormMenu.Name = "FormMenu"
		Me.FormMenu.Size = New System.Drawing.Size(474, 24)
		Me.FormMenu.TabIndex = 6
		Me.FormMenu.Text = "MenuStrip1"
		'
		'TraySettingsToolStripMenuItem
		'
		Me.TraySettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_Mini, Me.TSMI_Start, Me.TSMI_Logon})
		Me.TraySettingsToolStripMenuItem.Name = "TraySettingsToolStripMenuItem"
		Me.TraySettingsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
		Me.TraySettingsToolStripMenuItem.Text = "Control settings"
		'
		'TSMI_Mini
		'
		Me.TSMI_Mini.CheckOnClick = True
		Me.TSMI_Mini.Name = "TSMI_Mini"
		Me.TSMI_Mini.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TSMI_Mini.Size = New System.Drawing.Size(183, 22)
		Me.TSMI_Mini.Text = "Launch minimized"
		'
		'TSMI_Start
		'
		Me.TSMI_Start.CheckOnClick = True
		Me.TSMI_Start.Name = "TSMI_Start"
		Me.TSMI_Start.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TSMI_Start.Size = New System.Drawing.Size(183, 22)
		Me.TSMI_Start.Text = "Start GDPI on launch"
		'
		'TSMI_Logon
		'
		Me.TSMI_Logon.CheckOnClick = True
		Me.TSMI_Logon.Name = "TSMI_Logon"
		Me.TSMI_Logon.Size = New System.Drawing.Size(183, 22)
		Me.TSMI_Logon.Text = "Launch on logon"
		'
		'ListsToolStripMenuItem
		'
		Me.ListsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_Blacklist, Me.TSMI_Userlist})
		Me.ListsToolStripMenuItem.Name = "ListsToolStripMenuItem"
		Me.ListsToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
		Me.ListsToolStripMenuItem.Text = "Lists"
		'
		'TSMI_Blacklist
		'
		Me.TSMI_Blacklist.Name = "TSMI_Blacklist"
		Me.TSMI_Blacklist.Size = New System.Drawing.Size(158, 22)
		Me.TSMI_Blacklist.Text = "Update blacklist"
		'
		'TSMI_Userlist
		'
		Me.TSMI_Userlist.Name = "TSMI_Userlist"
		Me.TSMI_Userlist.Size = New System.Drawing.Size(158, 22)
		Me.TSMI_Userlist.Text = "Open userlist"
		'
		'TSMI_Debug
		'
		Me.TSMI_Debug.Name = "TSMI_Debug"
		Me.TSMI_Debug.Size = New System.Drawing.Size(75, 20)
		Me.TSMI_Debug.Text = "DebugInfo"
		Me.TSMI_Debug.Visible = False
		'
		'TLP_S
		'
		Me.TLP_S.ColumnCount = 1
		Me.TLP_S.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_S.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
		Me.TLP_S.Controls.Add(Me.FLP_Custom, 0, 0)
		Me.TLP_S.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TLP_S.Location = New System.Drawing.Point(0, 24)
		Me.TLP_S.Name = "TLP_S"
		Me.TLP_S.RowCount = 2
		Me.TLP_S.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TLP_S.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TLP_S.Size = New System.Drawing.Size(474, 539)
		Me.TLP_S.TabIndex = 9
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.FLP_Radio)
		Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 395)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(468, 141)
		Me.FlowLayoutPanel1.TabIndex = 10
		Me.FlowLayoutPanel1.WrapContents = False
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.AutoSize = True
		Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel2.Controls.Add(Me.CB_Blacklist)
		Me.FlowLayoutPanel2.Controls.Add(Me.CB_Userlist)
		Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(254, 3)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(92, 46)
		Me.FlowLayoutPanel2.TabIndex = 2
		'
		'CB_Blacklist
		'
		Me.CB_Blacklist.AutoSize = True
		Me.CB_Blacklist.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_ControlSettings, "UseBlacklist", True))
		Me.CB_Blacklist.Location = New System.Drawing.Point(3, 3)
		Me.CB_Blacklist.Name = "CB_Blacklist"
		Me.CB_Blacklist.Size = New System.Drawing.Size(86, 17)
		Me.CB_Blacklist.TabIndex = 0
		Me.CB_Blacklist.Text = "Use blacklist"
		Me.CB_Blacklist.UseVisualStyleBackColor = True
		'
		'CB_Userlist
		'
		Me.CB_Userlist.AutoSize = True
		Me.CB_Userlist.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_ControlSettings, "UseUserlist", True))
		Me.CB_Userlist.Location = New System.Drawing.Point(3, 26)
		Me.CB_Userlist.Name = "CB_Userlist"
		Me.CB_Userlist.Size = New System.Drawing.Size(80, 17)
		Me.CB_Userlist.TabIndex = 1
		Me.CB_Userlist.Text = "Use userlist"
		Me.CB_Userlist.UseVisualStyleBackColor = True
		'
		'BS_ControlSettings
		'
		Me.BS_ControlSettings.DataSource = GetType(GDPIControl.Data.ControlSettings)
		'
		'BS_GDPISettings
		'
		Me.BS_GDPISettings.DataSource = GetType(GDPIControl.Data.GDPISettings)
		'
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(474, 612)
		Me.Controls.Add(Me.TLP_S)
		Me.Controls.Add(Me.TLP_Buttons)
		Me.Controls.Add(Me.FormMenu)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.FormMenu
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(490, 650)
		Me.Name = "FormMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Settings"
		Me.TrayMenu.ResumeLayout(False)
		Me.FLP_Custom.ResumeLayout(False)
		Me.FLP_Custom.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		CType(Me.NUD_F, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.TableLayoutPanel4.PerformLayout()
		CType(Me.HUD_K, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel5.ResumeLayout(False)
		Me.TableLayoutPanel5.PerformLayout()
		CType(Me.NUD_E, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.TableLayoutPanel7.ResumeLayout(False)
		Me.TableLayoutPanel7.PerformLayout()
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FLP_Radio.ResumeLayout(False)
		Me.FLP_Radio.PerformLayout()
		Me.TLP_Buttons.ResumeLayout(False)
		Me.TLP_Buttons.PerformLayout()
		Me.FormMenu.ResumeLayout(False)
		Me.FormMenu.PerformLayout()
		Me.TLP_S.ResumeLayout(False)
		Me.TLP_S.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.FlowLayoutPanel2.ResumeLayout(False)
		Me.FlowLayoutPanel2.PerformLayout()
		CType(Me.BS_ControlSettings, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BS_GDPISettings, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TrayControl As NotifyIcon
	Friend WithEvents TrayMenu As ContextMenuStrip
	Friend WithEvents TSMI_Enable As ToolStripMenuItem
	Friend WithEvents TSMI_Disable As ToolStripMenuItem
	Friend WithEvents TSMI_Settings As ToolStripMenuItem
	Friend WithEvents TSMI_Close As ToolStripMenuItem
	Friend WithEvents BS_GDPISettings As BindingSource
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents FLP_Custom As FlowLayoutPanel
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents CheckBox4 As CheckBox
	Friend WithEvents CB_DNS As CheckBox
	Friend WithEvents DNS_Port As TextBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents DNS_IP As TextBox
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents DNS6_IP As TextBox
	Friend WithEvents DNS6_Port As TextBox
	Friend WithEvents CB_DNS6 As CheckBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents CB As CheckBox
	Friend WithEvents NUD_F As NumericUpDown
	Friend WithEvents LB As Label
	Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
	Friend WithEvents CheckBox5 As CheckBox
	Friend WithEvents HUD_K As NumericUpDown
	Friend WithEvents Label3 As Label
	Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
	Friend WithEvents CheckBox6 As CheckBox
	Friend WithEvents NUD_E As NumericUpDown
	Friend WithEvents Label4 As Label
	Friend WithEvents CheckBox7 As CheckBox
	Friend WithEvents CheckBox8 As CheckBox
	Friend WithEvents CheckBox9 As CheckBox
	Friend WithEvents FLP_Radio As FlowLayoutPanel
	Friend WithEvents RB_Custom As RadioButton
	Friend WithEvents Label5 As Label
	Friend WithEvents RB_P1 As RadioButton
	Friend WithEvents RB_P2 As RadioButton
	Friend WithEvents RB_P3 As RadioButton
	Friend WithEvents RB_P4 As RadioButton
	Friend WithEvents B_Copy As Button
	Friend WithEvents B_Start As Button
	Friend WithEvents B_Stop As Button
	Friend WithEvents TLP_Buttons As TableLayoutPanel
	Friend WithEvents FormMenu As MenuStrip
	Friend WithEvents TraySettingsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TSMI_Mini As ToolStripMenuItem
	Friend WithEvents TSMI_Start As ToolStripMenuItem
	Friend WithEvents CheckBox10 As CheckBox
	Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
	Friend WithEvents CheckBox12 As CheckBox
	Friend WithEvents NumericUpDown1 As NumericUpDown
	Friend WithEvents Label6 As Label
	Friend WithEvents TLP_S As TableLayoutPanel
	Friend WithEvents ListsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TSMI_Blacklist As ToolStripMenuItem
	Friend WithEvents TSMI_Userlist As ToolStripMenuItem
	Friend WithEvents TSMI_Logon As ToolStripMenuItem
	Friend WithEvents TSMI_Debug As ToolStripMenuItem
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents CB_Blacklist As CheckBox
	Friend WithEvents CB_Userlist As CheckBox
	Friend WithEvents BS_ControlSettings As BindingSource
End Class
