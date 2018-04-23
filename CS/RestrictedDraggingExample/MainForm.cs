using System;
using System.Drawing;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraBars.Docking;
using RestrictedDraggingExample.Docking;

namespace RestrictedDraggingExample {
    public partial class MainForm :XtraForm {
        public MainForm() {
            InitializeComponent();
            DockingManager.ForceInitialize();
            DockPanel dp = new CustomDockPanel(DockingManager);
            dp.DockTo(DockingStyle.Float);
            dp.Text = "Test Panel";
            dp.Parent.Location = PointToScreen(Point.Empty);
        }
    }
}