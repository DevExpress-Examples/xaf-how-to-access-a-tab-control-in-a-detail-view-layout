<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128586641/22.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E372)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:


* [WinCustomizeTabControlViewController.cs](./CS/EFCore/AccessLayoutEF/AccessLayoutEF.Win/Controllers/WinCustomizeTabControlViewController.cs) 
<!-- default file list end -->
# How to access a tab control in a Detail View layout


<p><strong>Scenario</strong><br> This example demonstrates how to implement a View Controller that will access layout controls and customize them as required. In particular, the second tab in the tab control should become active when opening the detail form.<br><br></p>
<p><strong>Steps to implement</strong></p>
<p><strong>1.</strong> This functionality is implemented in the <em>WinCustomizeTabControlViewController</em> class that is added into the WinForms application projects (copy these classes into the respective projects of your test solution). 
<p><strong>2.</strong> To identify the layout element by the "TabbedGroup" string, make sure this identifier is specified under the Views | YourBusinessObject_DetailView | Layout node in the Model Editor invoked for the YourSolutionName.Module/<em>Model.DesignedDiffs.xafml</em> file.<br>

<strong>Blazor UI</strong> does not have give direct access to layout items, including tabbed groups. Thus, it is not possible to select a specific tab in code. To change tab captions, use the following solution: <a href="https://github.com/DevExpress-Examples/XAF-How-to-show-the-number-of-nested-list-views-items-in-tab-captions/tree/22.1.1%2B/DetailViewTabCount/ASP.NET/Blazor">XAF for Blazor - How to show the number of nested List View items in tab captions</a>.
<br>
<strong><br>See also:</strong> <br><a href="http://documentation.devexpress.com/#Xaf/CustomDocument2817"><u>eXpressApp Framework > Concepts > UI Construction > View Items Layout<br></u></a><u><a href="https://www.devexpress.com/Support/Center/p/T386111">How to show the number of the nested list view's items in the tab caption (Web)</a><br><a href="https://www.devexpress.com/Support/Center/p/T586150">How to set active tab in a Web DetailView layout after executing an Action</a><br>
  <a href="https://www.devexpress.com/Support/Center/p/t943913">How to show the number of nested List View items in tab captions</a><br></u></u></p>

<br/>


