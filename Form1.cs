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
        private bool fileSaved = true;
        private string currentFile = null;

        public Texteditor()
        {
            InitializeComponent();

            // Form closing event handler
            this.FormClosing += new FormClosingEventHandler(exitProgram_FormClosing);
        }

        private void document_TextChanged(object sender, EventArgs e)
        {
            // get values
            int count = document.Text.Split(new[] {' ', '\n'}, StringSplitOptions.RemoveEmptyEntries).Length;
            int charactersWithSpace = document.Text.Length;
            string[] charArray = document.Text.Split(' ');
            int charactersWithoutSpace = string.Join("", charArray).Length;
            int lines = document.Text.Split('\n').Length;

            if (fileSaved)
            {
                this.Text = "*" + this.Text;
                fileSaved = false;
            }

            // update values
            wordCount.Text = count.ToString();
            charsWithoutSpace.Text = charactersWithoutSpace.ToString();
            charsWithSpace.Text = "(" + charactersWithSpace.ToString() + ")";
            lineCount.Text = lines.ToString();
        }

        private void clearDoc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear the document? This will clear the current document.", "Clear document", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                document.Clear();
            }
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            var f = new Texteditor();
            f.Show();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (!fileSaved)
            {
                DialogResult result = UnsavedFilePrompt();
                if (result == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = fileDialog.FileName;
                string contents = File.ReadAllText(currentFile);

                document.Text = contents;
                this.Text = FormatTitle(currentFile);
                fileSaved = true;
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            PromptSaveDialog();
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // This interferes with ExitPrompt() and this.Close()
        // Checks if there are any unsaved changes and asks the user for action
        private void exitProgram_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!fileSaved)
            {
                DialogResult result = UnsavedFilePrompt();
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                } else if (result == DialogResult.No)
                {
                    e.Cancel = false;
                } else if (result == DialogResult.Yes)
                {
                    SaveFile();
                    if (!fileSaved) { e.Cancel = true; }
                }
            }
        }

        // Prompts the user for file save action
        private DialogResult UnsavedFilePrompt()
        {
            DialogResult result = MessageBox.Show("There are unsaved changes. Do you wish to save the file?", "Exit program", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            return result;
        }

        // Saves the file
        private void SaveFile()
        {
            if (currentFile == null)
            {
                PromptSaveDialog();
                return;
            } else
            {
                File.WriteAllText(currentFile, document.Text);
                this.Text = FormatTitle(currentFile);
                fileSaved = true;
            }
        }

        // Handles file save and file destination
        private void PromptSaveDialog()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();

            fileDialog.Filter = "Text files (*.txt)|*.txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = fileDialog.FileName;
                SaveFile();
            }
        }

        // Formats file path to file name 
        private string FormatTitle(string path)
        {
            string[] entries = path.Split('\\');
            string title = entries[entries.Length - 1];
            return title;
        }
    }
}
