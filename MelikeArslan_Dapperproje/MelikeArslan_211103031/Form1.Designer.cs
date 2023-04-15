namespace MelikeArslan_211103031
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.textBox_KullaniciAd = new System.Windows.Forms.TextBox();
            this.button_Giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Location = new System.Drawing.Point(122, 104);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.PasswordChar = '*';
            this.textBox_Sifre.Size = new System.Drawing.Size(100, 25);
            this.textBox_Sifre.TabIndex = 11;
            // 
            // textBox_KullaniciAd
            // 
            this.textBox_KullaniciAd.Location = new System.Drawing.Point(139, 42);
            this.textBox_KullaniciAd.Name = "textBox_KullaniciAd";
            this.textBox_KullaniciAd.Size = new System.Drawing.Size(141, 25);
            this.textBox_KullaniciAd.TabIndex = 10;
            // 
            // button_Giris
            // 
            this.button_Giris.BackColor = System.Drawing.Color.Khaki;
            this.button_Giris.Image = global::MelikeArslan_211103031.Properties.Resources.favicon__2_;
            this.button_Giris.Location = new System.Drawing.Point(276, 104);
            this.button_Giris.Name = "button_Giris";
            this.button_Giris.Size = new System.Drawing.Size(74, 57);
            this.button_Giris.TabIndex = 14;
            this.button_Giris.UseVisualStyleBackColor = false;
            this.button_Giris.Click += new System.EventHandler(this.button_Giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(383, 175);
            this.Controls.Add(this.button_Giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_KullaniciAd);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.TextBox textBox_KullaniciAd;
        private System.Windows.Forms.Button button_Giris;
    }
}

