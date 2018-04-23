using System;
using System.Drawing;
using DevExpress.XtraBars.Docking.Helpers;

namespace RestrictedDraggingExample.Docking {
    public class CustomDockingHandlerStateVS2005 :DockingHandlerStateVS2005 {
        public CustomDockingHandlerStateVS2005(DockPanelMouseHandler handler): base(handler) { }

        protected override Point CalcDockPanelLocationWithOffset(Point point) {
            Point result = base.CalcDockPanelLocationWithOffset(point);
            Point topLeft = DockManager.Form.PointToScreen(DockManager.Form.ClientRectangle.Location);
            Point bottomright = DockManager.Form.PointToScreen(new Point(DockManager.Form.ClientRectangle.Right,
                DockManager.Form.ClientRectangle.Bottom));
            return new Point(Math.Max(Math.Min(result.X, bottomright.X - Owner.Width),
                topLeft.X), Math.Max(Math.Min(result.Y, bottomright.Y - Owner.Height),
                topLeft.Y));
        }
    }
}
