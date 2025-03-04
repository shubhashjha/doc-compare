using DiffPlex.DiffBuilder;
using DiffPlex;
using DiffPlex.DiffBuilder.Model;

namespace DocCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string file1Path = "";
        private string file2Path = "";

        private void btn_File1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file1Path = openFileDialog.FileName;
                R_TextBox1.Text = File.ReadAllText(file1Path);
            }
        }

        private void Btn_Compare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(file1Path) || string.IsNullOrEmpty(file2Path))
            {
                MessageBox.Show("Please select both files before comparing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string file1Content = File.ReadAllText(file1Path);
            string file2Content = File.ReadAllText(file2Path);

            var diffBuilder = new SideBySideDiffBuilder(new Differ());
            var diffResult = diffBuilder.BuildDiffModel(file1Content, file2Content);

            HighlightDifferences(diffResult);
        }
        private void HighlightDifferences(SideBySideDiffModel diffResult)
        {
            R_TextBox1.Clear();
            R_TextBox2.Clear();

            foreach (var line in diffResult.OldText.Lines)
            {
                AppendColoredText(R_TextBox1, line.Text + Environment.NewLine, line.Type);
            }

            foreach (var line in diffResult.NewText.Lines)
            {
                AppendColoredText(R_TextBox2, line.Text + Environment.NewLine, line.Type);
            }
        }

        private void AppendColoredText(RichTextBox rtb, string text, ChangeType changeType)
        {
            switch (changeType)
            {
                case ChangeType.Inserted:
                    rtb.SelectionColor = System.Drawing.Color.DarkGreen;  // Highlight new text
                    break;
                case ChangeType.Deleted:
                    rtb.SelectionColor = System.Drawing.Color.DarkRed;    // Highlight removed text
                    break;
                case ChangeType.Modified:
                    rtb.SelectionColor = System.Drawing.Color.DarkBlue;   // Highlight modified text
                    break;
                default:
                    rtb.SelectionColor = System.Drawing.Color.Black;  // Default color
                    break;
            }

            rtb.AppendText(text);
        }

        private void btn_File2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file2Path = openFileDialog.FileName;
                R_TextBox2.Text = File.ReadAllText(file2Path);
            }
        }
    }
}
