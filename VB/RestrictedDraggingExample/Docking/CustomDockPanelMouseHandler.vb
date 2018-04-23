Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking.Helpers

Namespace RestrictedDraggingExample.Docking
	Public Class CustomDockPanelMouseHandler
		Inherits DockPanelMouseHandler
		Public Sub New(ByVal owner As DockPanel)
			MyBase.New(owner)
		End Sub

		Protected Overrides Function CreateHandlerState(ByVal state As DockPanelState) As BaseHandlerState
			If state = DockPanelState.Docking AndAlso Owner.DockManager.DockMode = DockMode.VS2005 Then
				Return New CustomDockingHandlerStateVS2005(Me)
			End If
			Return MyBase.CreateHandlerState(state)
		End Function
	End Class
End Namespace
