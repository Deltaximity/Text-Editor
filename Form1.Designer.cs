namespace Text_Editor
{
    partial class Texteditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.document = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.charsWithoutSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.charsWithSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lineCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.openFile,
            this.toolStripSeparator2,
            this.saveFile,
            this.saveAs,
            this.toolStripSeparator1,
            this.exitProgram});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFile
            // 
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(121, 22);
            this.newFile.Text = "New";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(121, 22);
            this.openFile.Text = "Open...";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(121, 22);
            this.saveFile.Text = "Save";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(121, 22);
            this.saveAs.Text = "Save as...";
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // exitProgram
            // 
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(121, 22);
            this.exitProgram.Text = "Exit";
            this.exitProgram.Click += new System.EventHandler(this.exitProgram_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDoc});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearDoc
            // 
            this.clearDoc.Name = "clearDoc";
            this.clearDoc.Size = new System.Drawing.Size(101, 22);
            this.clearDoc.Text = "Clear";
            this.clearDoc.Click += new System.EventHandler(this.clearDoc_Click);
            // 
            // document
            // 
            this.document.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.document.BackColor = System.Drawing.Color.White;
            this.document.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.document.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.document.Location = new System.Drawing.Point(0, 27);
            this.document.Name = "document";
            this.document.Size = new System.Drawing.Size(584, 314);
            this.document.TabIndex = 2;
            this.document.Text = "";
            this.document.TextChanged += new System.EventHandler(this.document_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.wordCount,
            this.toolStripStatusLabel2,
            this.charsWithoutSpace,
            this.charsWithSpace,
            this.toolStripStatusLabel3,
            this.lineCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 337);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 19);
            this.toolStripStatusLabel1.Text = "Words:";
            // 
            // wordCount
            // 
            this.wordCount.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.wordCount.Name = "wordCount";
            this.wordCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wordCount.Size = new System.Drawing.Size(13, 19);
            this.wordCount.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(70, 19);
            this.toolStripStatusLabel2.Text = "Characters:";
            // 
            // charsWithoutSpace
            // 
            this.charsWithoutSpace.Name = "charsWithoutSpace";
            this.charsWithoutSpace.Size = new System.Drawing.Size(13, 19);
            this.charsWithoutSpace.Text = "0";
            // 
            // charsWithSpace
            // 
            this.charsWithSpace.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.charsWithSpace.Name = "charsWithSpace";
            this.charsWithSpace.Size = new System.Drawing.Size(21, 19);
            this.charsWithSpace.Text = "(0)";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(41, 19);
            this.toolStripStatusLabel3.Text = "Lines:";
            // 
            // lineCount
            // 
            this.lineCount.Name = "lineCount";
            this.lineCount.Size = new System.Drawing.Size(13, 19);
            this.lineCount.Text = "0";
            // 
            // Texteditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.document);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Texteditor";
            this.Text = "Untitled.txt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripMenuItem exitProgram;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox document;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDoc;
        private System.Windows.Forms.ToolStripStatusLabel wordCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel charsWithoutSpace;
        private System.Windows.Forms.ToolStripStatusLabel charsWithSpace;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lineCount;
    }
}

