using DevExpress.XtraRichEdit.API.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace WpfRichEditorMenuCustomization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            richTextEditor.Document.Text = "The WPF Rich Text Editor allows you to integrate word processing " +
                "capabilities into your next WPF project. With its comprehensive text formatting options, " +
                "mail-merge, and a rich collection of end-user options you can deliver Microsoft Word-inspired " +
                "functionality with ease.";
        }


        private void HighlightSelection_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var selectedRanges = richTextEditor.Document.Selections;
            foreach (var range in selectedRanges)
            {
                var charProps = richTextEditor.Document.BeginUpdateCharacters(range);
                charProps.BackColor = System.Drawing.Color.Yellow;
                richTextEditor.Document.EndUpdateCharacters(charProps);
            }
        }
    }
}
