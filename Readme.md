<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128617362/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3900)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomDockingHandlerStateVS2005.cs](./CS/RestrictedDraggingExample/Docking/CustomDockingHandlerStateVS2005.cs) (VB: [CustomDockingHandlerStateVS2005.vb](./VB/RestrictedDraggingExample/Docking/CustomDockingHandlerStateVS2005.vb))
* [CustomDockPanel.cs](./CS/RestrictedDraggingExample/Docking/CustomDockPanel.cs) (VB: [CustomDockPanel.vb](./VB/RestrictedDraggingExample/Docking/CustomDockPanel.vb))
* [CustomDockPanelMouseHandler.cs](./CS/RestrictedDraggingExample/Docking/CustomDockPanelMouseHandler.cs) (VB: [CustomDockPanelMouseHandler.vb](./VB/RestrictedDraggingExample/Docking/CustomDockPanelMouseHandler.vb))
<!-- default file list end -->
# How to prevent the DockPanel from being dragged outside the Form bounds


<p>When the DockPanel is being dragged, its position is controlled by our internal classes. This example demonstrates how to create your own handler by sub-classing the DevExpress.XtraBars.Docking.Handlers.DockingHandlerStateVS2005 class. The only method that has to be changed is the CalcDockPanelLocationWithOffset method. This method should return a point at which the top-left corner of the DockPanel should be located based on the mouse position.</p>

<br/>


