namespace FileConverter.Main.Views
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.crownTextBox1 = new ReaLTaiizor.Controls.CrownTextBox();
            this.crownButton1 = new ReaLTaiizor.Controls.CrownButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAceptar = new ReaLTaiizor.Controls.MaterialButton();
            this.buttonCancelar = new ReaLTaiizor.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.crownDropDownList1 = new ReaLTaiizor.Controls.CrownDropDownList();
            this.SuspendLayout();
            // 
            // crownTextBox1
            // 
            this.crownTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.crownTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crownTextBox1.Enabled = false;
            this.crownTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownTextBox1.Location = new System.Drawing.Point(5, 128);
            this.crownTextBox1.Name = "crownTextBox1";
            this.crownTextBox1.ReadOnly = true;
            this.crownTextBox1.Size = new System.Drawing.Size(322, 29);
            this.crownTextBox1.TabIndex = 1;
            // 
            // crownButton1
            // 
            this.crownButton1.Location = new System.Drawing.Point(333, 128);
            this.crownButton1.Name = "crownButton1";
            this.crownButton1.Padding = new System.Windows.Forms.Padding(5);
            this.crownButton1.Size = new System.Drawing.Size(86, 29);
            this.crownButton1.TabIndex = 2;
            this.crownButton1.Text = "Examinar";
            this.crownButton1.Click += new System.EventHandler(this.crownButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(5, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carpeta de guardado:";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAceptar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAceptar.Depth = 0;
            this.buttonAceptar.HighEmphasis = true;
            this.buttonAceptar.Icon = null;
            this.buttonAceptar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.buttonAceptar.Location = new System.Drawing.Point(298, 402);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAceptar.MaximumSize = new System.Drawing.Size(120, 40);
            this.buttonAceptar.MinimumSize = new System.Drawing.Size(120, 40);
            this.buttonAceptar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAceptar.Size = new System.Drawing.Size(120, 40);
            this.buttonAceptar.TabIndex = 4;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAceptar.UseAccentColor = false;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonCancelar.Depth = 0;
            this.buttonCancelar.HighEmphasis = true;
            this.buttonCancelar.Icon = null;
            this.buttonCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.buttonCancelar.Location = new System.Drawing.Point(6, 402);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCancelar.MaximumSize = new System.Drawing.Size(120, 40);
            this.buttonCancelar.MinimumSize = new System.Drawing.Size(120, 40);
            this.buttonCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCancelar.Size = new System.Drawing.Size(120, 40);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonCancelar.UseAccentColor = false;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(5, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Idioma:";
            // 
            // crownDropDownList1
            // 
            this.crownDropDownList1.Location = new System.Drawing.Point(5, 200);
            this.crownDropDownList1.Name = "crownDropDownList1";
            this.crownDropDownList1.Size = new System.Drawing.Size(322, 26);
            this.crownDropDownList1.TabIndex = 7;
            this.crownDropDownList1.Text = "crownDropDownList1";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.ControlBox = false;
            this.Controls.Add(this.crownDropDownList1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crownButton1);
            this.Controls.Add(this.crownTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Image = global::FileConverter.Main.Properties.Resources.rikka_okay1;
            this.MaximumSize = new System.Drawing.Size(424, 450);
            this.MinimumSize = new System.Drawing.Size(424, 450);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.CrownTextBox crownTextBox1;
        private ReaLTaiizor.Controls.CrownButton crownButton1;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialButton buttonAceptar;
        private ReaLTaiizor.Controls.MaterialButton buttonCancelar;
        private Label label2;
        private ReaLTaiizor.Controls.CrownDropDownList crownDropDownList1;
    }
}