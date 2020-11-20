Imports System.ComponentModel

Public Class DateTimeS
	Inherits DateTimePicker

	Public Sub New()
		MyBase.ShowCheckBox = True
	End Sub

	<Bindable(True), RefreshProperties(RefreshProperties.All)>
	Public Overloads Property Value As Date?
		Get
			If Checked Then
				Return MyBase.Value
			Else
				Return Nothing
			End If
		End Get
		Set(value As Date?)
			MyBase.Value = If(value, Now)
		End Set
	End Property

	Public Overloads ReadOnly Property ShowCheckBox As Boolean

End Class