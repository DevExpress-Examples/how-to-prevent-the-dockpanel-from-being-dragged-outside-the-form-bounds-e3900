using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking.Helpers;

namespace RestrictedDraggingExample.Docking {
    public class CustomDockPanelMouseHandler :DockPanelMouseHandler {
        public CustomDockPanelMouseHandler(DockPanel owner) : base(owner) { }

        protected override BaseHandlerState CreateHandlerState(DockPanelState state) {
            if (state == DockPanelState.Docking && Owner.DockManager.DockMode == DockMode.VS2005)
                return new CustomDockingHandlerStateVS2005(this);
            return base.CreateHandlerState(state);
        }
    }
}
