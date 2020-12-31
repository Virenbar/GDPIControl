<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBlacklist
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
		Me.PB = New System.Windows.Forms.ProgressBar()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.L_Size = New System.Windows.Forms.Label()
		Me.L_Done = New System.Windows.Forms.Label()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'PB
		'
		Me.TableLayoutPanel1.SetColumnSpan(Me.PB, 2)
		Me.PB.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PB.Location = New System.Drawing.Point(3, 3)
		Me.PB.Name = "PB"
		Me.PB.Size = New System.Drawing.Size(229, 23)
		Me.PB.TabIndex = 0
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.L_Size, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.PB, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.L_Done, 0, 1)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(235, 55)
		Me.TableLayoutPanel1.TabIndex = 1
		'
		'L_Size
		'
		Me.L_Size.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.L_Size.AutoSize = True
		Me.L_Size.Location = New System.Drawing.Point(193, 29)
		Me.L_Size.Name = "L_Size"
		Me.L_Size.Size = New System.Drawing.Size(39, 13)
		Me.L_Size.TabIndex = 2
		Me.L_Size.Text = "Label2"
		'
		'L_Done
		'
		Me.L_Done.AutoSize = True
		Me.L_Done.Location = New System.Drawing.Point(3, 29)
		Me.L_Done.Name = "L_Done"
		Me.L_Done.Size = New System.Drawing.Size(39, 13)
		Me.L_Done.TabIndex = 1
		Me.L_Done.Text = "Label1"
		'
		'FormBlacklist
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(235, 55)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FormBlacklist"
		Me.ShowIcon = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.Text = "Blacklist download"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PB As ProgressBar
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents L_Size As Label
	Friend WithEvents L_Done As Label
End Class
