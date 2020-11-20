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
		Me.EnableGDPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DisableGDPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.CheckBox3 = New System.Windows.Forms.CheckBox()
		Me.CheckBox4 = New System.Windows.Forms.CheckBox()
		Me.CB_DNS = New System.Windows.Forms.CheckBox()
		Me.DNS_Port = New System.Windows.Forms.TextBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DNS_IP = New System.Windows.Forms.TextBox()
		Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.DNS6_IP = New System.Windows.Forms.TextBox()
		Me.DNS6_Port = New System.Windows.Forms.TextBox()
		Me.CB_DNS6 = New System.Windows.Forms.CheckBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.NUD = New System.Windows.Forms.NumericUpDown()
		Me.LB = New System.Windows.Forms.Label()
		Me.CB = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.CheckBox5 = New System.Windows.Forms.CheckBox()
		Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
		Me.CheckBox6 = New System.Windows.Forms.CheckBox()
		Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.CheckBox7 = New System.Windows.Forms.CheckBox()
		Me.CheckBox8 = New System.Windows.Forms.CheckBox()
		Me.CheckBox9 = New System.Windows.Forms.CheckBox()
		Me.BS_GDPISettings = New System.Windows.Forms.BindingSource(Me.components)
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.RadioButton4 = New System.Windows.Forms.RadioButton()
		Me.RadioButton5 = New System.Windows.Forms.RadioButton()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TrayMenu.SuspendLayout()
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		CType(Me.NUD, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel4.SuspendLayout()
		CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel5.SuspendLayout()
		CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BS_GDPISettings, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'TrayControl
		'
		Me.TrayControl.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.TrayControl.ContextMenuStrip = Me.TrayMenu
		Me.TrayControl.Text = "GDPI Control"
		Me.TrayControl.Visible = True
		'
		'TrayMenu
		'
		Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableGDPIToolStripMenuItem, Me.DisableGDPIToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.CloseToolStripMenuItem})
		Me.TrayMenu.Name = "TrayMenu"
		Me.TrayMenu.Size = New System.Drawing.Size(142, 92)
		'
		'EnableGDPIToolStripMenuItem
		'
		Me.EnableGDPIToolStripMenuItem.Name = "EnableGDPIToolStripMenuItem"
		Me.EnableGDPIToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
		Me.EnableGDPIToolStripMenuItem.Text = "Enable GDPI"
		'
		'DisableGDPIToolStripMenuItem
		'
		Me.DisableGDPIToolStripMenuItem.Name = "DisableGDPIToolStripMenuItem"
		Me.DisableGDPIToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
		Me.DisableGDPIToolStripMenuItem.Text = "Disable GDPI"
		'
		'SettingsToolStripMenuItem
		'
		Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
		Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
		Me.SettingsToolStripMenuItem.Text = "Settings"
		'
		'CloseToolStripMenuItem
		'
		Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
		Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
		Me.CloseToolStripMenuItem.Text = "Close"
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "P", True))
		Me.CheckBox1.Location = New System.Drawing.Point(3, 3)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CheckBox1.Size = New System.Drawing.Size(128, 17)
		Me.CheckBox1.TabIndex = 1
		Me.CheckBox1.Text = "-p Block passive DPI"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'NumericUpDown1
		'
		Me.NumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_GDPISettings, "E", True))
		Me.NumericUpDown1.Location = New System.Drawing.Point(644, 268)
		Me.NumericUpDown1.Name = "NumericUpDown1"
		Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
		Me.NumericUpDown1.TabIndex = 2
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(655, 346)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 20)
		Me.TextBox1.TabIndex = 3
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox1)
		Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox2)
		Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox3)
		Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox4)
		Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel3)
		Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel4)
		Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox7)
		Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel5)
		Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox8)
		Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox9)
		Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel1)
		Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel2)
		Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
		Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(503, 593)
		Me.FlowLayoutPanel1.TabIndex = 5
		'
		'CheckBox2
		'
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "R", True))
		Me.CheckBox2.Location = New System.Drawing.Point(3, 26)
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
		Me.CheckBox3.Location = New System.Drawing.Point(3, 49)
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
		Me.CheckBox4.Location = New System.Drawing.Point(3, 72)
		Me.CheckBox4.Name = "CheckBox4"
		Me.CheckBox4.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CheckBox4.Size = New System.Drawing.Size(257, 17)
		Me.CheckBox4.TabIndex = 4
		Me.CheckBox4.Text = "-m Mix Host header case (test.com -> tEsT.cOm)"
		Me.CheckBox4.UseVisualStyleBackColor = True
		'
		'CB_DNS
		'
		Me.CB_DNS.AutoSize = True
		Me.CB_DNS.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CB_DNS.Location = New System.Drawing.Point(3, 3)
		Me.CB_DNS.Name = "CB_DNS"
		Me.CB_DNS.Size = New System.Drawing.Size(15, 20)
		Me.CB_DNS.TabIndex = 0
		Me.CB_DNS.UseVisualStyleBackColor = True
		'
		'DNS_Port
		'
		Me.DNS_Port.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DNS_Port.Location = New System.Drawing.Point(180, 3)
		Me.DNS_Port.Name = "DNS_Port"
		Me.DNS_Port.Size = New System.Drawing.Size(50, 20)
		Me.DNS_Port.TabIndex = 1
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
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 260)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(497, 26)
		Me.TableLayoutPanel1.TabIndex = 7
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label1.Location = New System.Drawing.Point(236, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(258, 26)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Redirect UDP DNS requests to the supplied IP address:port"
		'
		'DNS_IP
		'
		Me.DNS_IP.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DNS_IP.Location = New System.Drawing.Point(24, 3)
		Me.DNS_IP.Name = "DNS_IP"
		Me.DNS_IP.Size = New System.Drawing.Size(150, 20)
		Me.DNS_IP.TabIndex = 3
		'
		'MaskedTextBox1
		'
		Me.MaskedTextBox1.Location = New System.Drawing.Point(664, 403)
		Me.MaskedTextBox1.Mask = "990\.990\.990\.900"
		Me.MaskedTextBox1.Name = "MaskedTextBox1"
		Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
		Me.MaskedTextBox1.TabIndex = 6
		Me.MaskedTextBox1.Text = "1111"
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
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 292)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(497, 26)
		Me.TableLayoutPanel2.TabIndex = 8
		'
		'DNS6_IP
		'
		Me.DNS6_IP.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DNS6_IP.Location = New System.Drawing.Point(24, 3)
		Me.DNS6_IP.Name = "DNS6_IP"
		Me.DNS6_IP.Size = New System.Drawing.Size(150, 20)
		Me.DNS6_IP.TabIndex = 3
		'
		'DNS6_Port
		'
		Me.DNS6_Port.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DNS6_Port.Location = New System.Drawing.Point(180, 3)
		Me.DNS6_Port.Name = "DNS6_Port"
		Me.DNS6_Port.Size = New System.Drawing.Size(50, 20)
		Me.DNS6_Port.TabIndex = 1
		'
		'CB_DNS6
		'
		Me.CB_DNS6.AutoSize = True
		Me.CB_DNS6.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CB_DNS6.Location = New System.Drawing.Point(3, 3)
		Me.CB_DNS6.Name = "CB_DNS6"
		Me.CB_DNS6.Size = New System.Drawing.Size(15, 20)
		Me.CB_DNS6.TabIndex = 0
		Me.CB_DNS6.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label2.Location = New System.Drawing.Point(236, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(258, 26)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Redirect UDPv6 DNS requests to the supplied IPv6 address:port"
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
		Me.TableLayoutPanel3.Controls.Add(Me.NUD, 1, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.LB, 2, 0)
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 95)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(256, 26)
		Me.TableLayoutPanel3.TabIndex = 7
		'
		'NUD
		'
		Me.NUD.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_GDPISettings, "F_Value", True))
		Me.NUD.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.BS_GDPISettings, "F_State", True))
		Me.NUD.Location = New System.Drawing.Point(24, 3)
		Me.NUD.Name = "NUD"
		Me.NUD.Size = New System.Drawing.Size(51, 20)
		Me.NUD.TabIndex = 2
		'
		'LB
		'
		Me.LB.AutoSize = True
		Me.LB.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LB.Location = New System.Drawing.Point(81, 0)
		Me.LB.Name = "LB"
		Me.LB.Size = New System.Drawing.Size(172, 26)
		Me.LB.TabIndex = 0
		Me.LB.Text = "-f Set HTTP fragmentation to value"
		Me.LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'CB
		'
		Me.CB.AutoSize = True
		Me.CB.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "F_State", True))
		Me.CB.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CB.Location = New System.Drawing.Point(3, 3)
		Me.CB.Name = "CB"
		Me.CB.Size = New System.Drawing.Size(15, 20)
		Me.CB.TabIndex = 1
		Me.CB.UseVisualStyleBackColor = True
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
		Me.TableLayoutPanel4.Controls.Add(Me.NumericUpDown2, 1, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.Label3, 2, 0)
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 127)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 1
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(428, 26)
		Me.TableLayoutPanel4.TabIndex = 8
		'
		'CheckBox5
		'
		Me.CheckBox5.AutoSize = True
		Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "F_State", True))
		Me.CheckBox5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CheckBox5.Location = New System.Drawing.Point(3, 3)
		Me.CheckBox5.Name = "CheckBox5"
		Me.CheckBox5.Size = New System.Drawing.Size(15, 20)
		Me.CheckBox5.TabIndex = 1
		Me.CheckBox5.UseVisualStyleBackColor = True
		'
		'NumericUpDown2
		'
		Me.NumericUpDown2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_GDPISettings, "F_Value", True))
		Me.NumericUpDown2.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.BS_GDPISettings, "F_State", True))
		Me.NumericUpDown2.Location = New System.Drawing.Point(24, 3)
		Me.NumericUpDown2.Name = "NumericUpDown2"
		Me.NumericUpDown2.Size = New System.Drawing.Size(51, 20)
		Me.NumericUpDown2.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label3.Location = New System.Drawing.Point(81, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(344, 26)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "-k Enable HTTP persistent (keep-alive) fragmentation and set it to value"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
		Me.TableLayoutPanel5.Controls.Add(Me.NumericUpDown3, 1, 0)
		Me.TableLayoutPanel5.Controls.Add(Me.Label4, 2, 0)
		Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 182)
		Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
		Me.TableLayoutPanel5.RowCount = 1
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel5.Size = New System.Drawing.Size(266, 26)
		Me.TableLayoutPanel5.TabIndex = 8
		'
		'CheckBox6
		'
		Me.CheckBox6.AutoSize = True
		Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "F_State", True))
		Me.CheckBox6.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CheckBox6.Location = New System.Drawing.Point(3, 3)
		Me.CheckBox6.Name = "CheckBox6"
		Me.CheckBox6.Size = New System.Drawing.Size(15, 20)
		Me.CheckBox6.TabIndex = 1
		Me.CheckBox6.UseVisualStyleBackColor = True
		'
		'NumericUpDown3
		'
		Me.NumericUpDown3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_GDPISettings, "F_Value", True))
		Me.NumericUpDown3.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.BS_GDPISettings, "F_State", True))
		Me.NumericUpDown3.Location = New System.Drawing.Point(24, 3)
		Me.NumericUpDown3.Name = "NumericUpDown3"
		Me.NumericUpDown3.Size = New System.Drawing.Size(51, 20)
		Me.NumericUpDown3.TabIndex = 2
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label4.Location = New System.Drawing.Point(81, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(182, 26)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "-e Set HTTPS fragmentation to value"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'CheckBox7
		'
		Me.CheckBox7.AutoSize = True
		Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "N", True))
		Me.CheckBox7.Location = New System.Drawing.Point(3, 159)
		Me.CheckBox7.Name = "CheckBox7"
		Me.CheckBox7.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CheckBox7.Size = New System.Drawing.Size(288, 17)
		Me.CheckBox7.TabIndex = 7
		Me.CheckBox7.Text = "-n Do not wait for first segment ACK when -k is enabled"
		Me.CheckBox7.UseVisualStyleBackColor = True
		'
		'CheckBox8
		'
		Me.CheckBox8.AutoSize = True
		Me.CheckBox8.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "A", True))
		Me.CheckBox8.Location = New System.Drawing.Point(3, 214)
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
		Me.CheckBox9.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_GDPISettings, "W", True))
		Me.CheckBox9.Location = New System.Drawing.Point(3, 237)
		Me.CheckBox9.Name = "CheckBox9"
		Me.CheckBox9.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CheckBox9.Size = New System.Drawing.Size(407, 17)
		Me.CheckBox9.TabIndex = 10
		Me.CheckBox9.Text = "-w Try to find And parse HTTP traffic on all processed ports (Not only on port 80" &
	")"
		Me.CheckBox9.UseVisualStyleBackColor = True
		'
		'BS_GDPISettings
		'
		Me.BS_GDPISettings.DataSource = GetType(GDPIControl.Data.GDPISettings)
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(86, 17)
		Me.RadioButton1.TabIndex = 7
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "User settings"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.AutoSize = True
		Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel2.Controls.Add(Me.RadioButton1)
		Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel2.Controls.Add(Me.RadioButton2)
		Me.FlowLayoutPanel2.Controls.Add(Me.RadioButton3)
		Me.FlowLayoutPanel2.Controls.Add(Me.RadioButton4)
		Me.FlowLayoutPanel2.Controls.Add(Me.RadioButton5)
		Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 324)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(245, 128)
		Me.FlowLayoutPanel2.TabIndex = 8
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(3, 39)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(181, 17)
		Me.RadioButton2.TabIndex = 8
		Me.RadioButton2.TabStop = True
		Me.RadioButton2.Text = "-1 Most compatible mode, default"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Location = New System.Drawing.Point(3, 62)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(239, 17)
		Me.RadioButton3.TabIndex = 9
		Me.RadioButton3.TabStop = True
		Me.RadioButton3.Text = "-2 Better speed for HTTPS yet still compatible"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'RadioButton4
		'
		Me.RadioButton4.AutoSize = True
		Me.RadioButton4.Location = New System.Drawing.Point(3, 85)
		Me.RadioButton4.Name = "RadioButton4"
		Me.RadioButton4.Size = New System.Drawing.Size(204, 17)
		Me.RadioButton4.TabIndex = 10
		Me.RadioButton4.TabStop = True
		Me.RadioButton4.Text = "-3 Better speed for HTTP and HTTPS"
		Me.RadioButton4.UseVisualStyleBackColor = True
		'
		'RadioButton5
		'
		Me.RadioButton5.AutoSize = True
		Me.RadioButton5.Location = New System.Drawing.Point(3, 108)
		Me.RadioButton5.Name = "RadioButton5"
		Me.RadioButton5.Size = New System.Drawing.Size(90, 17)
		Me.RadioButton5.TabIndex = 11
		Me.RadioButton5.TabStop = True
		Me.RadioButton5.Text = "-4 Best speed"
		Me.RadioButton5.UseVisualStyleBackColor = True
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
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(776, 617)
		Me.Controls.Add(Me.MaskedTextBox1)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.NumericUpDown1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FormMain"
		Me.Text = "Settings"
		Me.TrayMenu.ResumeLayout(False)
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		CType(Me.NUD, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.TableLayoutPanel4.PerformLayout()
		CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel5.ResumeLayout(False)
		Me.TableLayoutPanel5.PerformLayout()
		CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BS_GDPISettings, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel2.ResumeLayout(False)
		Me.FlowLayoutPanel2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TrayControl As NotifyIcon
	Friend WithEvents TrayMenu As ContextMenuStrip
	Friend WithEvents EnableGDPIToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DisableGDPIToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BS_GDPISettings As BindingSource
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents NumericUpDown1 As NumericUpDown
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents CheckBox4 As CheckBox
	Friend WithEvents CB_DNS As CheckBox
	Friend WithEvents DNS_Port As TextBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents DNS_IP As TextBox
	Friend WithEvents MaskedTextBox1 As MaskedTextBox
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents DNS6_IP As TextBox
	Friend WithEvents DNS6_Port As TextBox
	Friend WithEvents CB_DNS6 As CheckBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents CB As CheckBox
	Friend WithEvents NUD As NumericUpDown
	Friend WithEvents LB As Label
	Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
	Friend WithEvents CheckBox5 As CheckBox
	Friend WithEvents NumericUpDown2 As NumericUpDown
	Friend WithEvents Label3 As Label
	Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
	Friend WithEvents CheckBox6 As CheckBox
	Friend WithEvents NumericUpDown3 As NumericUpDown
	Friend WithEvents Label4 As Label
	Friend WithEvents CheckBox7 As CheckBox
	Friend WithEvents CheckBox8 As CheckBox
	Friend WithEvents CheckBox9 As CheckBox
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents Label5 As Label
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents RadioButton4 As RadioButton
	Friend WithEvents RadioButton5 As RadioButton
End Class
