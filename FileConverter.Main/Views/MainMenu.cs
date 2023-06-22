using FileConverter.Main.Complementaries;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace FileConverter.Main.Views
{
    public partial class MainMenu : LostForm
    {
        private string[] imgFileTypes = { ".jpeg", ".png", ".ico", ".gif", ".webp" };
        private string[] videoFileTypes = { ".mp4", ".wav" };
        private string[] audioFileTypes = { "", "" };
        private Stream fileStream;
        private string fileName;

        public MainMenu()
        {
            fileName = string.Empty;
            InitializeComponent();
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
        }

        private void socialButton1_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog();
            PopulateStrings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Images (*.jpeg; *.png; *.ico; *.gif; *.webp)| *.jpeg; *.png; *.ico; *.gif; *.webp";
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
            string convSelected = string.Empty;
            if (materialComboBox1.SelectedValue != null)
            {
                convSelected = (string)materialComboBox1.SelectedValue;
                if (fileStream != null)
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
            fileStream.Dispose();
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
    }
}
