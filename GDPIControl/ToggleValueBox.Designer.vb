<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToggleValueBox
	Inherits System.Windows.Forms.UserControl

	'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
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
		Me.LB = New System.Windows.Forms.Label()
		Me.CB = New System.Windows.Forms.CheckBox()
		Me.NUD = New System.Windows.Forms.NumericUpDown()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		CType(Me.NUD, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'LB
		'
		Me.LB.AutoSize = True
		Me.LB.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LB.Location = New System.Drawing.Point(3, 0)
		Me.LB.Name = "LB"
		Me.LB.Size = New System.Drawing.Size(28, 105)
		Me.LB.TabIndex = 0
		Me.LB.Text = "TVB"
		Me.LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'CB
		'
		Me.CB.AutoSize = True
		Me.CB.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CB.Location = New System.Drawing.Point(37, 3)
		Me.CB.Name = "CB"
		Me.CB.Size = New System.Drawing.Size(15, 99)
		Me.CB.TabIndex = 1
		Me.CB.UseVisualStyleBackColor = True
		'
		'NUD
		'
		Me.NUD.AutoSize = True
		Me.NUD.Dock = System.Windows.Forms.DockStyle.Fill
		Me.NUD.Location = New System.Drawing.Point(58, 3)
		Me.NUD.Name = "NUD"
		Me.NUD.Size = New System.Drawing.Size(244, 20)
		Me.NUD.TabIndex = 2
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.NUD, 2, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.LB, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.CB, 1, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(305, 105)
		Me.TableLayoutPanel1.TabIndex = 3
		'
		'ToggleValueBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Name = "ToggleValueBox"
		Me.Size = New System.Drawing.Size(305, 105)
		CType(Me.NUD, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LB As Label
	Friend WithEvents CB As CheckBox
	Friend WithEvents NUD As NumericUpDown
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
