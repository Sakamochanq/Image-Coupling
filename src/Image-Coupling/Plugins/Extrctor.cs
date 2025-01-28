using System;
using System.IO;
using System.Windows.Forms;
using PdfiumViewer;

namespace Image_Coupling.Plugins
{
    public partial class Extrctor : Form
    {
        public Extrctor()
        {
            InitializeComponent();
        }

        public void Extract(string pdfPath, string outputDir, int dpiX, int dpiY)
        {
            try
            {
                using (var document = PdfiumViewer.PdfDocument.Load(pdfPath))
                {
                    for (int pageIndex = 0; pageIndex < document.PageCount; pageIndex++)
                    {
                        using (var image = document.Render(pageIndex, dpiX, dpiY, PdfiumViewer.PdfRenderFlags.CorrectFromDpi))
                        {
                            string imagePath = Path.Combine(outputDir, $"Page_{pageIndex + 1}.png");
                            image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }

        private int DPI_X = 100;
        private int DPI_Y = 100;

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                Extract(TargetBox.Text, OutputBox.Text, DPI_X, DPI_Y);
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
                OutputBox.Text = AppDomain.CurrentDomain.BaseDirectory;
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
