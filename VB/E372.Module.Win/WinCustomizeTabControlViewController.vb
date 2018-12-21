Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.XtraLayout
Imports DevExpress.ExpressApp.Win.Layout

Namespace E372.Module.Web
	Public Class WinCustomizeTabControlViewController
		Inherits ViewController(Of DetailView)
		Private tabbedGroup As TabbedControlGroup
		Private layoutManager As WinLayoutManager
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			layoutManager = CType(View.LayoutManager, WinLayoutManager)
			AddHandler layoutManager.ItemCreated, AddressOf OnItemCreated
			AddHandler layoutManager.LayoutCreated, AddressOf OnLayoutCreated
		End Sub
		Private Sub OnItemCreated(ByVal sender As Object, ByVal e As ItemCreatedEventArgs)
			' Check this Id in the E372.Module/Model.DesignedDiffs.xafml file
			If e.ModelLayoutElement.Id = "TabbedGroup" Then
				tabbedGroup = CType(e.Item, TabbedControlGroup)
			End If
		End Sub
		Private Sub OnLayoutCreated(ByVal sender As Object, ByVal e As EventArgs)
			If tabbedGroup IsNot Nothing Then
				tabbedGroup.SelectedTabPageIndex = 1
			End If
		End Sub

		Protected Overrides Sub OnDeactivated()
			If layoutManager IsNot Nothing Then
				RemoveHandler layoutManager.ItemCreated, AddressOf OnItemCreated
				RemoveHandler layoutManager.LayoutCreated, AddressOf OnLayoutCreated
				layoutManager = Nothing
			End If
			tabbedGroup = Nothing
			MyBase.OnDeactivated()
		End Sub
	End Class
End Namespace
