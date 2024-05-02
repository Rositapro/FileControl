namespace FileControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSaveAsWord = new Button();
            btnSaveTextFile = new Button();
            txtContent = new TextBox();
            btnOpenTextFile = new Button();
            txtProcessFileNumber = new TextBox();
            btnProcessFolder = new Button();
            txtFolder = new TextBox();
            btnSelectFolder = new Button();
            SuspendLayout();
            // 
            // btnSaveAsWord
            // 
            btnSaveAsWord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveAsWord.Location = new Point(520, 118);
            btnSaveAsWord.Name = "btnSaveAsWord";
            btnSaveAsWord.Size = new Size(182, 45);
            btnSaveAsWord.TabIndex = 15;
            btnSaveAsWord.Text = "Save As Word";
            btnSaveAsWord.UseVisualStyleBackColor = true;
            btnSaveAsWord.Click += btnSaveAsWord_Click;
            // 
            // btnSaveTextFile
            // 
            btnSaveTextFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveTextFile.Location = new Point(297, 118);
            btnSaveTextFile.Name = "btnSaveTextFile";
            btnSaveTextFile.Size = new Size(182, 45);
            btnSaveTextFile.TabIndex = 14;
            btnSaveTextFile.Text = "Save Text File";
            btnSaveTextFile.UseVisualStyleBackColor = true;
            btnSaveTextFile.Click += btnSaveTextFile_Click;
            // 
            // txtContent
            // 
            txtContent.Font = new Font("Segoe UI", 20F);
            txtContent.Location = new Point(29, 196);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Both;
            txtContent.Size = new Size(650, 215);
            txtContent.TabIndex = 13;
            // 
            // btnOpenTextFile
            // 
            btnOpenTextFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenTextFile.Location = new Point(29, 118);
            btnOpenTextFile.Name = "btnOpenTextFile";
            btnOpenTextFile.Size = new Size(125, 40);
            btnOpenTextFile.TabIndex = 12;
            btnOpenTextFile.Text = "Open Text File";
            btnOpenTextFile.UseVisualStyleBackColor = true;
            btnOpenTextFile.Click += btnOpenTextFile_Click;
            // 
            // txtProcessFileNumber
            // 
            txtProcessFileNumber.Font = new Font("Segoe UI", 20F);
            txtProcessFileNumber.Location = new Point(547, 53);
            txtProcessFileNumber.Name = "txtProcessFileNumber";
            txtProcessFileNumber.ReadOnly = true;
            txtProcessFileNumber.Size = new Size(225, 43);
            txtProcessFileNumber.TabIndex = 11;
            // 
            // btnProcessFolder
            // 
            btnProcessFolder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcessFolder.Location = new Point(370, 39);
            btnProcessFolder.Name = "btnProcessFolder";
            btnProcessFolder.Size = new Size(158, 57);
            btnProcessFolder.TabIndex = 10;
            btnProcessFolder.Text = "Process Folder";
            btnProcessFolder.UseVisualStyleBackColor = true;
            btnProcessFolder.Click += btnProcessFolder_Click;
            // 
            // txtFolder
            // 
            txtFolder.Font = new Font("Segoe UI", 20F);
            txtFolder.Location = new Point(176, 53);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(159, 43);
            txtFolder.TabIndex = 9;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectFolder.Location = new Point(29, 51);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(125, 45);
            btnSelectFolder.TabIndex = 8;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveAsWord);
            Controls.Add(btnSaveTextFile);
            Controls.Add(txtContent);
            Controls.Add(btnOpenTextFile);
            Controls.Add(txtProcessFileNumber);
            Controls.Add(btnProcessFolder);
            Controls.Add(txtFolder);
            Controls.Add(btnSelectFolder);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveAsWord;
        private Button btnSaveTextFile;
        private TextBox txtContent;
        private Button btnOpenTextFile;
        private TextBox txtProcessFileNumber;
        private Button btnProcessFolder;
        private TextBox txtFolder;
        private Button btnSelectFolder;
    }
}
