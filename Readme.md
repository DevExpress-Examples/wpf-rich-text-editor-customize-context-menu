<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128607567/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T537265)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ContextMenuCustomization/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ContextMenuCustomization/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/ContextMenuCustomization/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ContextMenuCustomization/MainWindow.xaml.vb))
<!-- default file list end -->
# How to customize the popup menu of the WPF RichEdit control


The following example illustrates how to customize the RichEditControl pop-up menus by removing existing menu items and adding new items.<br>In XAML, add new <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsBarItemtopic">BarItem elements</a> and <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsRemoveBarItemAndLinkActiontopic">RemoveBarItemAndLinkAction</a> actions to the <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfRichEditMenuRichEditMenuCustomizationtopic">RichEditMenuCustomization</a> object contained in the RichEditControl.MenuCustomizations collection.<br>At runtime, handle the <a href="http://help.devexpress.com/#WPF/DevExpressXpfRichEditRichEditControl_PopupMenuShowingtopic">PopupMenuShowing</a> event, remove unnecessary menu items, add new <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsBarItemtopic">BarItem elements</a> and <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsRemoveBarItemAndLinkActiontopic">RemoveBarItemAndLinkAction</a> actions to the <a href="http://help.devexpress.com/#WPF/DevExpressXpfRichEditPopupMenuShowingEventArgs_Customizationstopic">e.Customizations</a> collection.<br><br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-the-popup-menu-of-the-wpf-richedit-control-t537265/17.2.3+/media/0a92eeb2-714f-4a60-846a-503b8ea4b4a4.png">

<br/>


