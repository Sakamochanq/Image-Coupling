using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace Image_Coupling.Plugins
{
    public partial class Extrctor : Form
    {
        private string title = "Extractor";

        public Extrctor()
        {
            InitializeComponent();

            this.DPISelectBox.Items.Add("100");
            this.DPISelectBox.Items.Add("300");
            this.DPISelectBox.SelectedIndex = 0;
            this.OpenFolderButton.Enabled = false;

            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "extracted");
        }

        public void Extract(string pdfPath, string outputDir, int dpiX, int dpiY)
        {
            try
            {
                using (var document = new PdfDocument())
                {
                    document.LoadFromFile(pdfPath);
                    for (int pageIndex = 1;  pageIndex < document.Pages.Count; pageIndex++)
                    {
                        Image image = document.SaveAsImage(pageIndex, PdfImageType.Bitmap, dpiY, dpiX);
                        string SavePath = string.Format($"{outputDir}\\Page_{pageIndex}.png");
                        image.Save(SavePath, ImageFormat.Png);
                    }
                }
                StatusLabel.Text = "すべての画像抽出が完了しました。";
            }
            catch (Exception ex)
            {
                StatusLabel.Text = "画像抽出に失敗しました。";
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
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", OutputBox.Text);
        }
        private void OutputBox_TextChanged(object sender, EventArgs e)
        {
            if (OutputBox.Text.Length != 0)
            {
                this.OpenFolderButton.Enabled = true;
            }
            else
            {
                this.OpenFolderButton.Enabled = false;
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

        private void OpenHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PDFと保存先を指定後、画像出力ボタンをクリックすると\n画像が抽出されます。", title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
