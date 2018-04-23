Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Docking.Helpers

Namespace RestrictedDraggingExample.Docking
	Public Class CustomDockPanel
		Inherits DockPanel
		Public Sub New(ByVal manager As DockManager)
			MyBase.New(True, DockingStyle.Float, manager)
		End Sub

		Protected Overrides Function CreateMouseHandler() As DockPanelMouseHandler
			Return New CustomDockPanelMouseHandler(Me)
		End Function
	End Class
End Namespace
