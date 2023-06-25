using FileConverter.Main.Complementaries;
using Patagames.Pdf;
using Patagames.Pdf.Net;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using Xabe.FFmpeg;

namespace FileConverter.Main.Views
{
    public partial class MainMenu : LostForm
    {
        private string[] imgFileTypes = { ".jpeg", ".png", ".ico", ".gif", ".webp", ".pdf" };
        private string[] videoFileTypes = { ".mp4", ".avi", ".webm", ".mkv", ".flv", ".vob", ".wmv", ".amv" };
        private string[] audioFileTypes = { ".mp3", ".wav", ".wma" };
        private Stream? fileStream;
        private string fileName;
        private OpenFileDialog openFileDialog;

        public MainMenu()
        {
            fileName = string.Empty;
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstLaunch)
            {
                Properties.Settings.Default.DownloadPath = Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile) + @"\Downloads";
                Properties.Settings.Default.FirstLaunch = false;
                Properties.Settings.Default.Save();
            }
            materialComboBox1.Enabled = false;
            materialButton1.Enabled = false;
            buttonDescargas.Visible = false;
            label2.Visible = false;
            PopulateStrings();
            this.MaximizeBox = false;
        }

        private void socialButton1_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog();
            PopulateStrings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter =
                "Media " +
                "(*.jpeg; *.png; *.ico; *.gif; *.webp; *.pdf; *.avi; *.mp4; *.webm; *.mkv; *.flv; *.vob; *.wmv; *.amv; *.mp3; *.wav; *.wma)" +
                "| *.jpeg; *.png; *.ico; *.gif; *.pdf; *.webp; *.avi; *.mp4; *.webm; *.mkv; *.flv; *.vob; *.wmv; *.amv; *.mp3; *.wav; *.wma";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                materialComboBox1.Enabled = true;
                materialButton1.Enabled = true;
                label1.Text = openFileDialog.SafeFileName;
                fileStream = openFileDialog.OpenFile();

                string fileType = label1.Text.Substring(label1.Text.LastIndexOf('.'));

                fileName = label1.Text.Substring(0, label1.Text.LastIndexOf('.'));
                if (imgFileTypes.Any(m => m == fileType))
                {
                    var list = imgFileTypes.ToList();
                    list.Remove(fileType);
                    materialComboBox1.DataSource = list;
                }
                if (videoFileTypes.Any(m => m == fileType))
                {
                    var list = videoFileTypes.ToList();
                    list.Remove(fileType);
                    materialComboBox1.DataSource = list;
                }
                if (audioFileTypes.Any(m => m == fileType))
                {
                    var list = audioFileTypes.ToList();
                    list.Remove(fileType);
                    materialComboBox1.DataSource = list;
                }
            }

        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            string convSelected = string.Empty;
            if (materialComboBox1.SelectedValue != null)
            {
                convSelected = (string)materialComboBox1.SelectedValue;
                if (fileStream != null)
                {
                    if (imgFileTypes.Contains(convSelected))
                    {
                        if (label1.Text.Substring(label1.Text.LastIndexOf('.')) != ".pdf")
                        {
                            Bitmap b = (Bitmap)Bitmap.FromStream(fileStream);

                            if (convSelected == ".png")
                            {
                                b.Save(Properties.Settings.Default.DownloadPath + @"\" + fileName + convSelected, ImageFormat.Png);
                            }
                            else if (convSelected == ".jpeg")
                            {
                                b.Save(Properties.Settings.Default.DownloadPath + @"\" + fileName + convSelected, ImageFormat.Jpeg);
                            }
                            else if (convSelected == ".ico")
                            {
                                b.Save(Properties.Settings.Default.DownloadPath + @"\" + fileName + convSelected, ImageFormat.Icon);
                            }
                            else if (convSelected == ".gif")
                            {
                                b.Save(Properties.Settings.Default.DownloadPath + @"\" + fileName + convSelected, ImageFormat.Gif);
                            }
                            else if (convSelected == ".webp")
                            {
                                b.Save(Properties.Settings.Default.DownloadPath + @"\" + fileName + convSelected, ImageFormat.Webp);
                            }
                            else if (convSelected == ".pdf")
                            {
                                PdfCommon.Initialize();
                                using (var doc = PdfDocument.CreateNew())
                                {
                                    using (PdfBitmap pdfBitmap = PdfBitmap.FromBitmap(b))
                                    {
                                        var imageObject = PdfImageObject.Create(doc, pdfBitmap, 0, 0);
                                        var size = new FS_SIZEF()
                                        {
                                            Width = pdfBitmap.Width * 72 / 300f,
                                            Height = pdfBitmap.Height * 72 / 300f
                                        };
                                        var page = doc.Pages.InsertPageAt(0, size);
                                        page.PageObjects.Add(imageObject);
                                        imageObject.Matrix = new FS_MATRIX(size.Width, 0, 0, size.Height, 0, 0);
                                        page.GenerateContent();
                                    }
                                    doc.Save(Properties.Settings.Default.DownloadPath + @"\" + fileName + convSelected, Patagames.Pdf.Enums.SaveFlags.NoIncremental);
                                }
                            } 
                        }
                        else
                        {
                            PdfCommon.Initialize();
                            using (var doc = PdfDocument.Load(openFileDialog.FileName))
                            {
                                int i = 0;
                                foreach (var page in doc.Pages)
                                {
                                    foreach (var obj in page.PageObjects)
                                    {
                                        var imageObject = obj as PdfImageObject;
                                        if (imageObject == null) continue;
                                        Bitmap b = (Bitmap)imageObject.Bitmap.GetImage();
                                        if (convSelected == ".png")
                                        {
                                            b.Save(Properties.Settings.Default.DownloadPath + @"\" + fileName + i + convSelected, ImageFormat.Png);
                                        }
                                        else if (convSelected == ".jpeg")
                                        {
                                            b.Save(Properties.Settings.Default.DownloadPath + @"\" + fileName + i + convSelected, ImageFormat.Jpeg);
                                        }
                                        else if (convSelected == ".ico")
                                        {
                                            b.Save(Properties.Settings.Default.DownloadPath + @"\" + fileName + i + convSelected, ImageFormat.Icon);
                                        }
                                        else if (convSelected == ".gif")
                                        {
                                            b.Save(Properties.Settings.Default.DownloadPath + @"\" + fileName + i + convSelected, ImageFormat.Gif);
                                        }
                                        else if (convSelected == ".webp")
                                        {
                                            b.Save(Properties.Settings.Default.DownloadPath + @"\" + fileName + i + convSelected, ImageFormat.Webp);
                                        }
                                        i++;
                                    }
                                }
                            }
                        }
                    }
                    else if (videoFileTypes.Contains(convSelected))
                    {
                        string outputFile = Path.ChangeExtension(
                                Properties.Settings.Default.DownloadPath + @"\" + openFileDialog.SafeFileName,
                                convSelected
                                );
                        ConvertVideo(outputFile, convSelected);
                    }
                    else if (audioFileTypes.Contains(convSelected))
                    {
                        string outputFile = Path.ChangeExtension(
                                Properties.Settings.Default.DownloadPath + @"\" + openFileDialog.SafeFileName,
                                convSelected
                                );
                        ConvertVideo(outputFile, convSelected);
                    }



                    label2.Visible = true;
                    materialComboBox1.Enabled = false;
                    materialButton1.Enabled = false;
                    buttonDescargas.Visible = true;
                    fileStream.Dispose();
                    label1.Text = string.Empty;
                }
            }
            else
            {
                throw new Exception("Error interno.");
            }
        }

        private void buttonDescargas_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Properties.Settings.Default.DownloadPath);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            materialComboBox1.Enabled = false;
            materialButton1.Enabled = false;
            buttonDescargas.Visible = false;
            if (fileStream != null)
            {
                fileStream.Dispose();
            }
            label1.Text = string.Empty;
            label2.Visible = false;
        }
        public void PopulateStrings()
        {
            this.Text = LanguageHelper.GetString("FileConverter");
            button1.Text = LanguageHelper.GetString("SelectFile");
            buttonDescargas.Text = LanguageHelper.GetString("SeeFolder");
            buttonReset.Text = LanguageHelper.GetString("Reset");
            materialButton1.Text = LanguageHelper.GetString("Convert");
            label2.Text = LanguageHelper.GetString("ConvertedText");
        }
        private void ConvertImage()
        {

        }
        private void ConvertAudio()
        {

        }
        private async void ConvertVideo(string outputFile, string convSelected)
        {
            if (File.Exists(outputFile))
            {
                File.Delete(outputFile);
            }
            var conversion = await FFmpeg.Conversions.FromSnippet.Convert(openFileDialog.FileName, outputFile);
            if (convSelected == ".amv")
            {
                conversion.AddParameter("-ac 1");
                conversion.AddParameter("-ar 22050");
                conversion.SetFrameRate(30);
                conversion.AddParameter("-block_size 735");
                conversion.AddParameter("-vstrict -1");
            }
            await conversion.Start();
        }
    }
}
