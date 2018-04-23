using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Web.Layout;

namespace E372.Module.Web {
    public class WebCustomizeTabControlViewController : ViewController<DetailView> {
        protected override void OnActivated() {
            base.OnActivated();
            ((WebLayoutManager)View.LayoutManager).PageControlCreated += OnPageControlCreated;
        }
        protected override void OnDeactivated() {
            ((WebLayoutManager)View.LayoutManager).PageControlCreated -= OnPageControlCreated;
            base.OnDeactivated();
        }
        private void OnPageControlCreated(object sender, PageControlCreatedEventArgs e) {
            // Check this Id in the E372.Module/Model.DesignedDiffs.xafml file
            if (e.Model.Id == "TabbedGroup") {
                e.PageControl.ClientSideEvents.Init = "function(s,e){s.SetActiveTabIndex(1);}";
                ((WebLayoutManager)View.LayoutManager).PageControlCreated -= OnPageControlCreated;
            }
        }
    }
}
