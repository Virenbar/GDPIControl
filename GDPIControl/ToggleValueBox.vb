Imports System.ComponentModel
Imports System.Drawing.Design
Imports GDPIControl.Data

Public Class ToggleValueBox

	<Bindable(True), SettingsBindable(True), DefaultValue(False), RefreshProperties(RefreshProperties.All)>
	Public Property Value As ToggleValue(Of Integer)
		Get
			Return New ToggleValue(Of Integer)() With {.Enabled = CB.Checked, .Value = CInt(NUD.Value)}
		End Get
		Set(value As ToggleValue(Of Integer))
			CB.Checked = value.Enabled
			NUD.Value = value.Value
		End Set
	End Property

	'<Bindable(True), SettingsBindable(True), RefreshProperties(RefreshProperties.All)>
	'<Editor("System.ComponentModel.Design.MultilineStringEditor, AssemblyRef.SystemDesign", GetType(UITypeEditor)), SettingsBindable(True)>
	<EditorBrowsable(EditorBrowsableState.Always), Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Bindable(True)>
	Public Overrides Property Text As String
		Get
			Return LB.Text
		End Get
		Set(value As String)
			LB.Text = value
		End Set
	End Property

	Private Sub CB_CheckedChanged(sender As Object, e As EventArgs) Handles CB.CheckedChanged
		NUD.Enabled = CB.Checked
	End Sub

End Class