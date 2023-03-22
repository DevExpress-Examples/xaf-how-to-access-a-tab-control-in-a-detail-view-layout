using System;
using DevExpress.ExpressApp;
using DevExpress.XtraLayout;
using DevExpress.ExpressApp.Win.Layout;

namespace AccessLayout.Win {
    public class WinCustomizeTabControlViewController : ViewController<DetailView> {
        TabbedControlGroup tabbedGroup;
        WinLayoutManager layoutManager;
        protected override void OnActivated() {
            base.OnActivated();
            layoutManager = (WinLayoutManager)View.LayoutManager;
            layoutManager.ItemCreated += OnItemCreated;
            layoutManager.LayoutCreated += OnLayoutCreated;
        }
        void OnItemCreated(object sender, ItemCreatedEventArgs e) {
            // Check this Id in the AccessLayoutEF.Module/Model.DesignedDiffs.xafml file
            if (e.ModelLayoutElement.Id == "MyTabbedGroup") {
                tabbedGroup = (TabbedControlGroup)e.Item;
            }
        }
        private void OnLayoutCreated(object sender, EventArgs e) {
            if (tabbedGroup != null) {
               tabbedGroup.SelectedTabPageIndex = 1;
            }
        }

        protected override void OnDeactivated() {
            if (layoutManager != null) {
                layoutManager.ItemCreated -= OnItemCreated;
                layoutManager.LayoutCreated -= OnLayoutCreated;
                layoutManager = null;
            }
            tabbedGroup = null;
            base.OnDeactivated();
        }
    }
}
