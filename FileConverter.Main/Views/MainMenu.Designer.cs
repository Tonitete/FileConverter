namespace FileConverter.Main.Views
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            button1 = new ReaLTaiizor.Controls.Button();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            socialButton1 = new ReaLTaiizor.Controls.SocialButton();
            materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            label1 = new Label();
            label2 = new Label();
            buttonDescargas = new ReaLTaiizor.Controls.Button();
            buttonReset = new ReaLTaiizor.Controls.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(32, 34, 37);
            button1.Location = new Point(100, 200);
            button1.Name = "button1";
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(120, 40);
            button1.TabIndex = 1;
            button1.Text = "Seleccionar Archivo";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(350, 200);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MaximumSize = new Size(120, 40);
            materialButton1.MinimumSize = new Size(120, 40);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(120, 40);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Convertir";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // socialButton1
            // 
            socialButton1.DownEllipseColor = Color.FromArgb(153, 34, 34);
            socialButton1.HoverEllipseColor = Color.FromArgb(32, 34, 37);
            socialButton1.Image = Properties.Resources.icons8_settings_50;
            socialButton1.Location = new Point(521, 39);
            socialButton1.Name = "socialButton1";
            socialButton1.NormalEllipseColor = Color.FromArgb(66, 76, 85);
            socialButton1.Size = new Size(54, 54);
            socialButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            socialButton1.TabIndex = 4;
            socialButton1.Text = "socialButton1";
            socialButton1.Click += socialButton1_Click;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.Black;
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.White;
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(226, 109);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(121, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 176);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(226, 334);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 7;
            // 
            // buttonDescargas
            // 
            buttonDescargas.BackColor = Color.Transparent;
            buttonDescargas.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonDescargas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDescargas.Image = null;
            buttonDescargas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDescargas.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonDescargas.Location = new Point(226, 405);
            buttonDescargas.Name = "buttonDescargas";
            buttonDescargas.PressedColor = Color.FromArgb(165, 37, 37);
            buttonDescargas.Size = new Size(120, 40);
            buttonDescargas.TabIndex = 8;
            buttonDescargas.Text = "Ver en carpeta";
            buttonDescargas.TextAlignment = StringAlignment.Center;
            buttonDescargas.Click += buttonDescargas_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Transparent;
            buttonReset.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Image = null;
            buttonReset.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReset.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonReset.Location = new Point(5, 39);
            buttonReset.Name = "buttonReset";
            buttonReset.PressedColor = Color.FromArgb(165, 37, 37);
            buttonReset.Size = new Size(67, 25);
            buttonReset.TabIndex = 9;
            buttonReset.Text = "Reset";
            buttonReset.TextAlignment = StringAlignment.Center;
            buttonReset.Click += buttonReset_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 450);
            Controls.Add(buttonReset);
            Controls.Add(buttonDescargas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(materialComboBox1);
            Controls.Add(socialButton1);
            Controls.Add(materialButton1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = (Image)resources.GetObject("$this.Image");
            MaximumSize = new Size(580, 450);
            MinimumSize = new Size(580, 450);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Converter";
            Load += MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.SocialButton socialButton1;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private Label label1;
        private Label label2;
        private ReaLTaiizor.Controls.Button buttonDescargas;
        private ReaLTaiizor.Controls.Button buttonReset;
    }
}