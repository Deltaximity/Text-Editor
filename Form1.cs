using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class Texteditor : Form
    {
        bool fileSaved = true;

        public Texteditor()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to exit? This will close down the current window.", "Exit program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to clear the document? This will clear the current document.", "Clear document", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {
                document.Clear();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Texteditor();
            f.Show();
        }

        private void document_TextChanged(object sender, EventArgs e)
        {
            var count = document.Text.Split(new[] {' ', '\n'}, StringSplitOptions.RemoveEmptyEntries).Length;
            var charactersWithSpace = document.Text.Length;
            // var charactersWithoutSpace = document.Text.Join(' ', {' '});

            if (fileSaved)
            {
                this.Text = "*" + this.Text;
                fileSaved = false;
            }

            wordCount.Text = count.ToString();
            characterCount.Text = charactersWithSpace.ToString();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();

            fileDialog.Filter = "Text files (*.txt)|*.txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                File.WriteAllText(path, document.Text);
                this.Text = FormatToTitle(path);
                fileSaved = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                string contents = File.ReadAllText(path);

                document.Text = contents;
                this.Text = FormatToTitle(path);
                fileSaved = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "Untitled.txt";
            File.WriteAllText(fileName, document.Text);
            this.Text = fileName;
            fileSaved = true;
        }

        // Formats file path into file name 
        private string FormatToTitle(string path)
        {
            string[] entries = path.Split('\\');
            string title = entries[entries.Length - 1];
            return title;
        }
    }
}
