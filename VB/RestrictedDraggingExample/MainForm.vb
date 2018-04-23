Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports DevExpress.XtraBars.Docking
Imports RestrictedDraggingExample.Docking

Namespace RestrictedDraggingExample
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			DockingManager.ForceInitialize()
			Dim dp As DockPanel = New CustomDockPanel(DockingManager)
			dp.DockTo(DockingStyle.Float)
			dp.Text = "Test Panel"
			dp.Parent.Location = PointToScreen(Point.Empty)
		End Sub
	End Class
End Namespace