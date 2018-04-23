Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraBars.Docking.Helpers

Namespace RestrictedDraggingExample.Docking
	Public Class CustomDockingHandlerStateVS2005
		Inherits DockingHandlerStateVS2005
		Public Sub New(ByVal handler As DockPanelMouseHandler)
			MyBase.New(handler)
		End Sub

		Protected Overrides Function CalcDockPanelLocationWithOffset(ByVal point As Point) As Point
			Dim result As Point = MyBase.CalcDockPanelLocationWithOffset(point)
			Dim topLeft As Point = DockManager.Form.PointToScreen(DockManager.Form.ClientRectangle.Location)
			Dim bottomright As Point = DockManager.Form.PointToScreen(New Point(DockManager.Form.ClientRectangle.Right, DockManager.Form.ClientRectangle.Bottom))
			Return New Point(Math.Max(Math.Min(result.X, bottomright.X - Owner.Width), topLeft.X), Math.Max(Math.Min(result.Y, bottomright.Y - Owner.Height), topLeft.Y))
		End Function
	End Class
End Namespace
