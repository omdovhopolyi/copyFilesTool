namespace CopyFilesTool
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxFiles = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectFrom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectTo = new System.Windows.Forms.Button();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(7, 156);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(527, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(61, 12);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(379, 23);
            this.textBoxFrom.TabIndex = 1;
            // 
            // textBoxFiles
            // 
            this.textBoxFiles.Location = new System.Drawing.Point(61, 41);
            this.textBoxFiles.Name = "textBoxFiles";
            this.textBoxFiles.Size = new System.Drawing.Size(379, 23);
            this.textBoxFiles.TabIndex = 2;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(61, 70);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(379, 23);
            this.textBoxTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // btnSelectFrom
            // 
            this.btnSelectFrom.Location = new System.Drawing.Point(462, 12);
            this.btnSelectFrom.Name = "btnSelectFrom";
            this.btnSelectFrom.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFrom.TabIndex = 0;
            this.btnSelectFrom.Text = "...";
            this.btnSelectFrom.UseVisualStyleBackColor = true;
            this.btnSelectFrom.Click += new System.EventHandler(this.btnSelectFrom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, -85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "label1";
            // 
            // btnSelectTo
            // 
            this.btnSelectTo.Location = new System.Drawing.Point(462, 70);
            this.btnSelectTo.Name = "btnSelectTo";
            this.btnSelectTo.Size = new System.Drawing.Size(75, 23);
            this.btnSelectTo.TabIndex = 0;
            this.btnSelectTo.Text = "...";
            this.btnSelectTo.UseVisualStyleBackColor = true;
            this.btnSelectTo.Click += new System.EventHandler(this.btnSelectTo_Click);
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(462, 40);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "...";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, -60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "label1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "File extention";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            ".jpeg",
            ".CR2"});
            this.comboBox.Location = new System.Drawing.Point(96, 127);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 23);
            this.comboBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Prefix";
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Location = new System.Drawing.Point(61, 99);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrefix.TabIndex = 8;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(7, 185);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(527, 254);
            this.richTextBox.TabIndex = 9;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 451);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.textBoxFiles);
            this.Controls.Add(this.btnSelectFrom);
            this.Controls.Add(this.btnSelectTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.btnCopy);
            this.Name = "Form1";
            this.Text = "Copy files tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCopy;
        private TextBox textBoxFrom;
        private TextBox textBoxFiles;
        private TextBox textBoxTo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSelectFrom;
        private Label label4;
        private Button btnSelectTo;
        private Button btnSelectFiles;
        private Label label5;
        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialog;
        private Label label6;
        private ComboBox comboBox;
        private Label label7;
        private TextBox textBoxPrefix;
        private RichTextBox richTextBox;
    }
}