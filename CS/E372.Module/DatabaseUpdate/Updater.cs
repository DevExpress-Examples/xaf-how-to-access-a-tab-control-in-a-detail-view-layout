using System;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;

namespace E372.Module.DatabaseUpdate {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            if (ObjectSpace.GetObjectsCount(typeof(Person), null) == 0) {
                Person p = ObjectSpace.CreateObject<Person>();
                p.FirstName = "Test Person";
                ObjectSpace.CommitChanges();
            }
        }
    }
}
