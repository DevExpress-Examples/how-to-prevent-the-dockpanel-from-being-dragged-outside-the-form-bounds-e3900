# How to prevent the DockPanel from being dragged outside the Form bounds


<p>When the DockPanel is being dragged, its position is controlled by our internal classes. This example demonstrates how to create your own handler by sub-classing the DevExpress.XtraBars.Docking.Handlers.DockingHandlerStateVS2005 class. The only method that has to be changed is the CalcDockPanelLocationWithOffset method. This method should return a point at which the top-left corner of the DockPanel should be located based on the mouse position.</p>


<h3>Description</h3>

<p>Starting from version 2011 vol 2, DevExpress WinForms controls no longer support Visual Studio 2005 and .NET Framework 2.0 and 3.0: <a href="http://www.devexpress.com/Support/WhatsNew/DXperience/files/11.2.5.bc.xml#BC-FW"><u>BC-FW: For WinForms and ASP.NET Controls</u></a></p>

<br/>


