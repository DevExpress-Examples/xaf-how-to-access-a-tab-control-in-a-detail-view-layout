using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Components.Models;
using Microsoft.AspNetCore.Components;
using DevExpress.ExpressApp.Blazor.Layout;

namespace AccessLayoutEF.Blazor {
    public class BlazorCustomizeTabControlViewController : ViewController<DetailView> {
        BlazorLayoutManager layoutManager;
        protected override void OnActivated() {
            base.OnActivated();
            layoutManager = (BlazorLayoutManager)View.LayoutManager;
            layoutManager.ItemCreated += OnItemCreated;
        }
        private void OnItemCreated(object sender, BlazorLayoutManager.ItemCreatedEventArgs e) {
            if (e.ModelLayoutElement.Id == "MyTabbedGroup" && e.LayoutControlItem is DxFormLayoutTabPagesModel tabbedGroup) {
                tabbedGroup.ActiveTabIndex = 1;
                tabbedGroup.ActiveTabIndexChanged = EventCallback.Factory.Create<int>(this, index => tabbedGroup.ActiveTabIndex = index);
            }
        }
        protected override void OnDeactivated() {
            if (layoutManager is not null) {
                layoutManager.ItemCreated -= OnItemCreated;
                layoutManager = null;
            }
            base.OnDeactivated();
        }
    }
}
