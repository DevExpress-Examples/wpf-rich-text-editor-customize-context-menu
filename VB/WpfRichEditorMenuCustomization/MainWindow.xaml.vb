Imports System

Namespace WpfRichEditorMenuCustomization

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DevExpress.Xpf.Core.ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
            Me.richTextEditor.Document.Text = "The WPF Rich Text Editor allows you to integrate word processing " & "capabilities into your next WPF project. With its comprehensive text formatting options, " & "mail-merge, and a rich collection of end-user options you can deliver Microsoft Word-inspired " & "functionality with ease."
        End Sub

        Private Sub HighlightSelection_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim selectedRanges = Me.richTextEditor.Document.Selections
            For Each range In selectedRanges
                Dim charProps = Me.richTextEditor.Document.BeginUpdateCharacters(range)
                charProps.BackColor = System.Drawing.Color.Yellow
                Me.richTextEditor.Document.EndUpdateCharacters(charProps)
            Next
        End Sub
    End Class
End Namespace
