# How to prevent the DockPanel from being dragged outside the Form bounds


<p>When the DockPanel is being dragged, its position is controlled by our internal classes. This example demonstrates how to create your own handler by sub-classing the DevExpress.XtraBars.Docking.Handlers.DockingHandlerStateVS2005 class. The only method that has to be changed is the CalcDockPanelLocationWithOffset method. This method should return a point at which the top-left corner of the DockPanel should be located based on the mouse position.</p>

<br/>


