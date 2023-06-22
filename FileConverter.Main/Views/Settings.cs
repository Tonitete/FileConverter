using FileConverter.Main.Complementaries;
using ReaLTaiizor.Forms;

namespace FileConverter.Main.Views
{
    public partial class Settings : LostForm
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            crownTextBox1.Text = Properties.Settings.Default.DownloadPath;
            crownDropDownList1.Items.Clear();
            crownDropDownList1.Items.Add(new ReaLTaiizor.Child.Crown.CrownDropDownItem("Español", Properties.Resources.espana));
            crownDropDownList1.Items.Add(new ReaLTaiizor.Child.Crown.CrownDropDownItem("English", Properties.Resources.reino_unido));
            string lang = Properties.Settings.Default.Language;
            if (lang == "es")
            {
                crownDropDownList1.SelectedItem = crownDropDownList1.Items[0];
            }
            else if (lang == "en")
            {
                crownDropDownList1.SelectedItem = crownDropDownList1.Items[1];
            }
            PopulateStrings();
        }

        private void crownButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                crownTextBox1.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string lang = crownDropDownList1.SelectedItem.Text;
            if (lang == "Español")
            {
                Properties.Settings.Default.Language = "es";
            }
            else if (lang == "English")
            {
                Properties.Settings.Default.Language = "en";
            }
            Properties.Settings.Default.DownloadPath = crownTextBox1.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        public void PopulateStrings()
        {
            this.Text = LanguageHelper.GetString("Settings");
            label1.Text = LanguageHelper.GetString("FolderText");
            crownButton1.Text = LanguageHelper.GetString("SelectFolder");
            label2.Text = LanguageHelper.GetString("Lang");
            buttonAceptar.Text = LanguageHelper.GetString("Accept");
            buttonCancelar.Text = LanguageHelper.GetString("Cancel");
        }
    }
}
