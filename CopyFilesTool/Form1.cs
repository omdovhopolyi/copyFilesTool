using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using System.Text;

namespace CopyFilesTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBoxPrefix.Text = "IMG_";
            comboBox.Text = ".CR2";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSelectFrom_Click(object sender, EventArgs e)
        {
            textBoxFrom.ForeColor = Color.Black;
            textBoxFrom.Text = "";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFrom.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            textBoxFiles.ForeColor = Color.Black;
            textBoxFiles.Text = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFiles.Text = openFileDialog.FileName;
            }
        }

        private void btnSelectTo_Click(object sender, EventArgs e)
        {
            textBoxTo.ForeColor = Color.Black;
            textBoxTo.Text = "";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxTo.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            bool isAllOk = true;

            if (String.IsNullOrEmpty(textBoxFrom.Text))
            {
                textBoxFrom.ForeColor = Color.Red;
                textBoxFrom.Text = "Set directory";
                isAllOk &= false;
            }
            if (String.IsNullOrEmpty(textBoxTo.Text))
            {
                textBoxTo.ForeColor = Color.Red;
                textBoxTo.Text = "Set directory";
                isAllOk &= false;
            }
            if (String.IsNullOrEmpty(textBoxFiles.Text))
            {
                textBoxFiles.ForeColor = Color.Red;
                textBoxFiles.Text = "Set file";
                isAllOk &= false;
            }
            
            if (isAllOk)
            {
                System.IO.Directory.CreateDirectory(textBoxTo.Text);

                foreach (string fileToCopy in System.IO.File.ReadLines(textBoxFiles.Text))
                {
                    string fileSrc = Path.ChangeExtension(
                        System.IO.Path.Combine(textBoxFrom.Text, textBoxPrefix.Text + fileToCopy)
                        , comboBox.Text
                    );

                    string fileDest = Path.ChangeExtension(
                        System.IO.Path.Combine(textBoxTo.Text, textBoxPrefix.Text + fileToCopy)
                        , comboBox.Text
                    );

                    try
                    {
                        System.IO.File.Copy(fileSrc, fileDest, true);

                        richTextBox.AppendText("Copy file: " + fileSrc + "\n");
                    }
                    catch 
                    {
                        richTextBox.SelectionColor = Color.Red;
                        richTextBox.AppendText("Can not copy file: " + fileSrc + "\n");
                        richTextBox.SelectionColor = Color.Black;
                    }
                }

                richTextBox.AppendText("Done");
            }
        }
    }
}