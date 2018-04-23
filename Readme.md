# How to customize the popup menu of the WPF RichEdit control


The following example illustrates how to customize the RichEditControl pop-up menus by removing existing menu items and adding new items.<br>In XAML, add new <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsBarItemtopic">BarItem elements</a> and <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsRemoveBarItemAndLinkActiontopic">RemoveBarItemAndLinkAction</a> actions to the <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfRichEditMenuRichEditMenuCustomizationtopic">RichEditMenuCustomization</a> object contained in the RichEditControl.MenuCustomizations collection.<br>At runtime, handle the <a href="http://help.devexpress.com/#WPF/DevExpressXpfRichEditRichEditControl_PopupMenuShowingtopic">PopupMenuShowing</a> event, remove unnecessary menu items, add new <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsBarItemtopic">BarItem elements</a> and <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfBarsRemoveBarItemAndLinkActiontopic">RemoveBarItemAndLinkAction</a> actions to the <a href="http://help.devexpress.com/#WPF/DevExpressXpfRichEditPopupMenuShowingEventArgs_Customizationstopic">e.Customizations</a> collection.<br><br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-the-popup-menu-of-the-wpf-richedit-control-t537265/17.2.3+/media/0a92eeb2-714f-4a60-846a-503b8ea4b4a4.png">

<br/>


