namespace WinFormsApp1
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
            buttonEncryptFile = new Button();
            buttonDecryptFile = new Button();
            buttonCreateAsmKeys = new Button();
            buttonExportPublicKey = new Button();
            buttonImportPublicKey = new Button();
            buttonGetPrivateKey = new Button();
            label1 = new Label();
            _encryptOpenFileDialog = new OpenFileDialog();
            _decryptOpenFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // buttonEncryptFile
            // 
            buttonEncryptFile.Location = new Point(25, 24);
            buttonEncryptFile.Name = "buttonEncryptFile";
            buttonEncryptFile.Size = new Size(75, 23);
            buttonEncryptFile.TabIndex = 0;
            buttonEncryptFile.Text = "button1";
            buttonEncryptFile.UseVisualStyleBackColor = true;
            buttonEncryptFile.Click += buttonEncryptFile_Click;
            // 
            // buttonDecryptFile
            // 
            buttonDecryptFile.Location = new Point(156, 24);
            buttonDecryptFile.Name = "buttonDecryptFile";
            buttonDecryptFile.Size = new Size(75, 23);
            buttonDecryptFile.TabIndex = 1;
            buttonDecryptFile.Text = "button2";
            buttonDecryptFile.UseVisualStyleBackColor = true;
            buttonDecryptFile.Click += buttonDecryptFile_Click;
            // 
            // buttonCreateAsmKeys
            // 
            buttonCreateAsmKeys.Location = new Point(282, 24);
            buttonCreateAsmKeys.Name = "buttonCreateAsmKeys";
            buttonCreateAsmKeys.Size = new Size(75, 23);
            buttonCreateAsmKeys.TabIndex = 2;
            buttonCreateAsmKeys.Text = "button3";
            buttonCreateAsmKeys.UseVisualStyleBackColor = true;
            buttonCreateAsmKeys.Click += buttonCreateAsmKeys_Click;
            // 
            // buttonExportPublicKey
            // 
            buttonExportPublicKey.Location = new Point(409, 24);
            buttonExportPublicKey.Name = "buttonExportPublicKey";
            buttonExportPublicKey.Size = new Size(75, 23);
            buttonExportPublicKey.TabIndex = 3;
            buttonExportPublicKey.Text = "button4";
            buttonExportPublicKey.UseVisualStyleBackColor = true;
            buttonExportPublicKey.Click += buttonExportPublicKey_Click;
            // 
            // buttonImportPublicKey
            // 
            buttonImportPublicKey.Location = new Point(542, 24);
            buttonImportPublicKey.Name = "buttonImportPublicKey";
            buttonImportPublicKey.Size = new Size(75, 23);
            buttonImportPublicKey.TabIndex = 4;
            buttonImportPublicKey.Text = "button5";
            buttonImportPublicKey.UseVisualStyleBackColor = true;
            buttonImportPublicKey.Click += buttonImportPublicKey_Click;
            // 
            // buttonGetPrivateKey
            // 
            buttonGetPrivateKey.Location = new Point(662, 24);
            buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            buttonGetPrivateKey.Size = new Size(75, 23);
            buttonGetPrivateKey.TabIndex = 5;
            buttonGetPrivateKey.Text = "button6";
            buttonGetPrivateKey.UseVisualStyleBackColor = true;
            buttonGetPrivateKey.Click += buttonGetPrivateKey_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 116);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 6;
            label1.Text = "Ключ не задан";
            // 
            // _encryptOpenFileDialog
            // 
            _encryptOpenFileDialog.FileName = "openFileDialog1";
            // 
            // _decryptOpenFileDialog
            // 
            _decryptOpenFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonGetPrivateKey);
            Controls.Add(buttonImportPublicKey);
            Controls.Add(buttonExportPublicKey);
            Controls.Add(buttonCreateAsmKeys);
            Controls.Add(buttonDecryptFile);
            Controls.Add(buttonEncryptFile);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEncryptFile;
        private Button buttonDecryptFile;
        private Button buttonCreateAsmKeys;
        private Button buttonExportPublicKey;
        private Button buttonImportPublicKey;
        private Button buttonGetPrivateKey;
        private Label label1;
        private OpenFileDialog _encryptOpenFileDialog;
        private OpenFileDialog _decryptOpenFileDialog;
    }
}
