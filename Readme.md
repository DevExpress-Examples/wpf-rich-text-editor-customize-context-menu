<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128607567/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T537265)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ContextMenuCustomization/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ContextMenuCustomization/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/ContextMenuCustomization/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ContextMenuCustomization/MainWindow.xaml.vb))
<!-- default file list end -->
# How to customize the popup menu of the WPF RichEdit control


The following example illustrates how to customize the RichEditControl pop-up menus by removing existing menu items and adding new items.<br>In XAML, add new <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsBarItemtopic">BarItem elements</a> and <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsRemoveBarItemAndLinkActiontopic">RemoveBarItemAndLinkAction</a> actions to the <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfRichEditMenuRichEditMenuCustomizationtopic">RichEditMenuCustomization</a> object contained in the RichEditControl.MenuCustomizations collection.<br>At runtime, handle the <a href="http://help.devexpress.com/#WPF/DevExpressXpfRichEditRichEditControl_PopupMenuShowingtopic">PopupMenuShowing</a> event, remove unnecessary menu items, add new <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsBarItemtopic">BarItem elements</a> and <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsRemoveBarItemAndLinkActiontopic">RemoveBarItemAndLinkAction</a> actions to the <a href="http://help.devexpress.com/#WPF/DevExpressXpfRichEditPopupMenuShowingEventArgs_Customizationstopic">e.Customizations</a> collection.<br><br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-the-popup-menu-of-the-wpf-richedit-control-t537265/17.2.3+/media/0a92eeb2-714f-4a60-846a-503b8ea4b4a4.png">

<br/>


<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-rich-text-editor-customize-context-menu&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-rich-text-editor-customize-context-menu&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
