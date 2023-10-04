<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128586641/22.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E372)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# XAF - How to access a tab control in a Detail View layout


This example implements a View Controller that accesses layout controls and customizes them as required. In particular, the second tab in the tab control should become active when the detail form is opened.


**WinForms** 

<kbd><img width="601" alt="Du2Er0SPZV" src="https://user-images.githubusercontent.com/14300209/226934893-008269a8-66b7-4f3e-a04a-d1a000d86e83.png"><kbd>

**ASP.NET Core Blazor**

<kbd>![|image](https://user-images.githubusercontent.com/33227868/231761563-86aaa8fa-ebaf-4b20-958e-a4190fafcfa4.png)</kbd>

## Implementation Details

1. This functionality is implemented in the [WinCustomizeTabControlViewController.cs](./CS/EFCore/AccessLayoutEF/AccessLayoutEF.Win/Controllers/WinCustomizeTabControlViewController.cs) and [BlazorCustomizeTabControlViewController.cs](./CS/EFCore/AccessLayoutEF/AccessLayoutEF.Blazor.Server/Controllers/BlazorCustomizeTabControlViewController.cs) classes, added to the WinForms and Blazor application projects respectively. Copy these classes to the corresponding projects in your test solution.

2. To identify the layout element by the **MyTabbedGroup** string, make sure this identifier is specified under the **Views | YourBusinessObject_DetailView | Layout** node in the Model Editor (invoked for the _YourSolutionName.Module/Model.DesignedDiffs.xafml_ file).


## Files to Review

* [WinCustomizeTabControlViewController.cs](./CS/EFCore/AccessLayoutEF/AccessLayoutEF.Win/Controllers/WinCustomizeTabControlViewController.cs) 
* [BlazorCustomizeTabControlViewController.cs](./CS/EFCore/AccessLayoutEF/AccessLayoutEF.Blazor.Server/Controllers/BlazorCustomizeTabControlViewController.cs) 

## Documentation

* [Detail View Layout Customization](https://docs.devexpress.com/eXpressAppFramework/112817/ui-construction/views/layout/view-items-layout-customization)

## More Examples

* [XAF - How to show the number of nested List View items in tab captions](https://github.com/DevExpress-Examples/XAF-How-to-show-the-number-of-nested-list-views-items-in-tab-captions)
* [How to set active tab in a Web DetailView layout after executing an Action](https://supportcenter.devexpress.com/ticket/details/t586150/how-to-set-active-tab-in-a-web-detailview-layout-after-executing-an-action)
