Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Web.Layout

Namespace E372.Module.Web
    Public Class WebCustomizeTabControlViewController
        Inherits ViewController(Of DetailView)

        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            AddHandler CType(View.LayoutManager, WebLayoutManager).PageControlCreated, AddressOf OnPageControlCreated
        End Sub
        Protected Overrides Sub OnDeactivated()
            RemoveHandler CType(View.LayoutManager, WebLayoutManager).PageControlCreated, AddressOf OnPageControlCreated
            MyBase.OnDeactivated()
        End Sub
        Private Sub OnPageControlCreated(ByVal sender As Object, ByVal e As PageControlCreatedEventArgs)
            ' Check this Id in the E372.Module/Model.DesignedDiffs.xafml file
            If e.Model.Id = "TabbedGroup" Then
                e.PageControl.ClientSideEvents.Init = "function(s,e){s.SetActiveTabIndex(1);}"
                RemoveHandler CType(View.LayoutManager, WebLayoutManager).PageControlCreated, AddressOf OnPageControlCreated
            End If
        End Sub
    End Class
End Namespace
