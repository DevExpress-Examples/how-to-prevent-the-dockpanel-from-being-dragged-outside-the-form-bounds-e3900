using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking.Helpers;

namespace RestrictedDraggingExample.Docking {
    public class CustomDockPanel :DockPanel {
        public CustomDockPanel(DockManager manager)
            : base(true, DockingStyle.Float, manager) { }

        protected override DockPanelMouseHandler CreateMouseHandler() {
            return new CustomDockPanelMouseHandler(this);
        }
    }
}
