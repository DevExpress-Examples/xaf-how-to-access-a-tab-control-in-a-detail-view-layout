Imports System
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.BaseImpl

Namespace E372.Module.DatabaseUpdate
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            If ObjectSpace.GetObjectsCount(GetType(Person), Nothing) = 0 Then
                Dim p As Person = ObjectSpace.CreateObject(Of Person)()
                p.FirstName = "Test Person"
                ObjectSpace.CommitChanges()
            End If
        End Sub
    End Class
End Namespace
