namespace MyWordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveDocument(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "My WordPad|*.rtf|Text|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(dlg.FileName).ToLower() == "*.rtf")
                {
                    richTextBox1.SaveFile(dlg.FileName);
                }
                else
                {
                    File.WriteAllText(dlg.FileName, richTextBox1.Text);
                }
            }
        }

        private void OpenDocument(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "My WordPad|*.rtf|Text|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(dlg.FileName).ToLower() == "*.rtf")
                {
                    richTextBox1.LoadFile(dlg.FileName);
                }
                else
                {
                    richTextBox1.Text = File.ReadAllText(dlg.FileName);
                }
            }
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new FontDialog();
            dlg.ShowColor = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = dlg.Font;
                richTextBox1.SelectionColor = dlg.Color;
            }
        }
    }
}
