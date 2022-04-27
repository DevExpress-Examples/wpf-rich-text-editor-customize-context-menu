Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.Xpf.RichEdit.Menu
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands

Namespace ContextMenuCustomization

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
            Me.richEdit.Document.AppendText("Table Test" & Microsoft.VisualBasic.Constants.vbCrLf)
            Dim table As Table = Me.richEdit.Document.Tables.Create(Me.richEdit.Document.Paragraphs(1).Range.Start, 8, 8)
            table.BeginUpdate()
            table.ForEachCell(Sub(ByVal cell, ByVal rowIndex, ByVal cellIndex) Me.richEdit.Document.InsertText(cell.Range.Start, String.Format("{0}:{1}", rowIndex, cellIndex)))
            table.EndUpdate()
        End Sub

#Region "#PopupMenuShowing"
        Private Sub RichEditPopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If(e.MenuType And RichEditMenuType.TableCell) <> 0 Then
                ' Remove the unnecessary buit-in items by their indices.
                For i As Integer = e.Menu.Items.Count - 1 To 14 Step -1
                    e.Menu.Items.RemoveAt(i)
                Next

                ' Remove the "Cut" and "Copy" menu items.
                e.Customizations.Add(New RemoveRichEditCommandAction() With {.Id = RichEditCommandId.CutSelection})
                e.Customizations.Add(New RemoveRichEditCommandAction() With {.Id = RichEditCommandId.CopySelection})
                ' Create a menu item for the RichEdit command, which invokes the Insert Picture dialog.
                e.Customizations.Add(New BarButtonItem() With {.Command = RichEditUICommand.InsertPicture, .Content = "Insert Picture", .CommandParameter = Me.richEdit})
                ' Create a custom menu item and handle its click event.
                Dim menuItem As BarButtonItem = New BarButtonItem()
                menuItem.Name = "customHighlightItem"
                menuItem.Content = "Highlight Selection"
                AddHandler menuItem.ItemClick, New ItemClickEventHandler(AddressOf customHighlightItem_ItemClick)
                e.Customizations.Add(menuItem)
            End If
        End Sub

        Private Sub customHighlightItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim charProps As CharacterProperties = Me.richEdit.Document.BeginUpdateCharacters(Me.richEdit.Document.Selection)
            charProps.BackColor = System.Drawing.Color.Yellow
            Me.richEdit.Document.EndUpdateCharacters(charProps)
        End Sub
#End Region  ' #PopupMenuShowing
    End Class
End Namespace
