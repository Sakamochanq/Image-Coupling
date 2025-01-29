using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Image_Coupling.Plugins
{
    public partial class Extrctor : Form
    {
        public Extrctor()
        {
            InitializeComponent();

            this.DPISelectBox.Items.Add("100");
            this.DPISelectBox.Items.Add("300");
            this.DPISelectBox.SelectedIndex = 0;

            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "extracted");
        }

        public void Extract(string pdfPath, string outputDir, int dpiX, int dpiY)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (DPISelectBox.SelectedIndex)
                {
                    case 0:
                        Extract(TargetBox.Text, OutputBox.Text, 100, 100);
                        break;
                    case 1:
                        Extract(TargetBox.Text, OutputBox.Text, 300, 300);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Extractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenPDFButton_Click(object sender, System.EventArgs e)
        {
            using (var ofd = new OpenFileDialog() { Filter = "PDFドキュメント（*.pdf）| *.pdf" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    TargetBox.Text = ofd.FileName;
                }
            }
        }

        private void SelectFolderButton_Click(object sender, System.EventArgs e)
        {
            using(var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    OutputBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void AutoCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (AutoCheckBox.Checked)
            {
                OutputBox.Text = AppDomain.CurrentDomain.BaseDirectory + "extracted";
                this.SelectFolderButton.Enabled = false;
                this.OutputBox.Enabled = false;
            }
            else
            {
                OutputBox.Text = null;
                this.SelectFolderButton.Enabled = true;
                this.OutputBox.Enabled = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
