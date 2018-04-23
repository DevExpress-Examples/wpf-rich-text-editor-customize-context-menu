using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.RichEdit;
using DevExpress.Xpf.RichEdit.Menu;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Commands;

namespace ContextMenuCustomization {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow {
        public MainWindow() {
            InitializeComponent();
            richEdit.Document.AppendText("Table Test\r\n");
            Table table = richEdit.Document.Tables.Create(richEdit.Document.Paragraphs[1].Range.Start, 8, 8);
            table.BeginUpdate();
            table.ForEachCell(delegate (TableCell cell, int rowIndex, int cellIndex) {
                richEdit.Document.InsertText(cell.Range.Start, string.Format("{0}:{1}", rowIndex, cellIndex));
            });
                table.EndUpdate();
        }

        #region #PopupMenuShowing
        private void RichEditPopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
                if ((e.MenuType & RichEditMenuType.TableCell) != 0) {

                // Remove the unnecessary buit-in items by their indices.
                for (int i = e.Menu.Items.Count - 1; i >= 14; i--) {
                        e.Menu.Items.RemoveAt(i);
                }

                // Remove the "Cut" and "Copy" menu items.
                e.Customizations.Add(new RemoveRichEditCommandAction() { Id = RichEditCommandId.CutSelection});
                e.Customizations.Add(new RemoveRichEditCommandAction() { Id = RichEditCommandId.CopySelection });
                // Create a menu item for the RichEdit command, which invokes the Insert Picture dialog.
                e.Customizations.Add(new BarButtonItem() {
                    Command = RichEditUICommand.InsertPicture,
                    Content = "Insert Picture",
                    CommandParameter = richEdit
                });

                // Create a custom menu item and handle its click event.
                BarButtonItem menuItem = new BarButtonItem();
                menuItem.Name = "customHighlightItem";
                menuItem.Content = "Highlight Selection";
                menuItem.ItemClick += new ItemClickEventHandler(customHighlightItem_ItemClick);
                e.Customizations.Add(menuItem);
            }
        }

        private void customHighlightItem_ItemClick(object sender, ItemClickEventArgs e) {
            CharacterProperties charProps = richEdit.Document.BeginUpdateCharacters(richEdit.Document.Selection);
            charProps.BackColor = System.Drawing.Color.Yellow;
            richEdit.Document.EndUpdateCharacters(charProps);
        }
        #endregion #PopupMenuShowing
    }
}
