namespace MelikeArslan_211103031
{
    partial class UrunHareketislemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunHareketislemleri));
            this.button1 = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Tip = new System.Windows.Forms.ComboBox();
            this.textBox_Bfiyat = new System.Windows.Forms.TextBox();
            this.textBox_Miktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Urun = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(485, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 50);
            this.button1.TabIndex = 81;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // temizle
            // 
            this.temizle.BackColor = System.Drawing.Color.Khaki;
            this.temizle.Location = new System.Drawing.Point(763, 205);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(93, 33);
            this.temizle.TabIndex = 80;
            this.temizle.Text = "TEMİZLE";
            this.temizle.UseVisualStyleBackColor = false;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.BackColor = System.Drawing.Color.Khaki;
            this.button_Sil.Location = new System.Drawing.Point(376, 113);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(93, 50);
            this.button_Sil.TabIndex = 79;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = false;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Ekle
            // 
            this.button_Ekle.BackColor = System.Drawing.Color.Khaki;
            this.button_Ekle.Location = new System.Drawing.Point(376, 57);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(93, 50);
            this.button_Ekle.TabIndex = 78;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = false;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // comboBox_Tip
            // 
            this.comboBox_Tip.FormattingEnabled = true;
            this.comboBox_Tip.Location = new System.Drawing.Point(99, 68);
            this.comboBox_Tip.Name = "comboBox_Tip";
            this.comboBox_Tip.Size = new System.Drawing.Size(121, 31);
            this.comboBox_Tip.TabIndex = 75;
            // 
            // textBox_Bfiyat
            // 
            this.textBox_Bfiyat.Location = new System.Drawing.Point(99, 177);
            this.textBox_Bfiyat.Name = "textBox_Bfiyat";
            this.textBox_Bfiyat.Size = new System.Drawing.Size(121, 30);
            this.textBox_Bfiyat.TabIndex = 74;
            this.textBox_Bfiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Miktar
            // 
            this.textBox_Miktar.Location = new System.Drawing.Point(101, 141);
            this.textBox_Miktar.Name = "textBox_Miktar";
            this.textBox_Miktar.Size = new System.Drawing.Size(119, 30);
            this.textBox_Miktar.TabIndex = 73;
            this.textBox_Miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 23);
            this.label5.TabIndex = 71;
            this.label5.Text = "Tip\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 70;
            this.label4.Text = "Birim Fiyat\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "Miktar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 68;
            this.label2.Text = "Ürün";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tarih";
            // 
            // comboBox_Urun
            // 
            this.comboBox_Urun.FormattingEnabled = true;
            this.comboBox_Urun.Location = new System.Drawing.Point(100, 104);
            this.comboBox_Urun.Name = "comboBox_Urun";
            this.comboBox_Urun.Size = new System.Drawing.Size(121, 31);
            this.comboBox_Urun.TabIndex = 82;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBox_Urun);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.temizle);
            this.groupBox1.Controls.Add(this.button_Sil);
            this.groupBox1.Controls.Add(this.button_Ekle);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox_Tip);
            this.groupBox1.Controls.Add(this.textBox_Bfiyat);
            this.groupBox1.Controls.Add(this.textBox_Miktar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(18, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 247);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(956, 349);
            this.dataGridView1.TabIndex = 84;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // UrunHareketislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(980, 646);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UrunHareketislemleri";
            this.Text = "UrunHareketislemleri";
            this.Load += new System.EventHandler(this.UrunHareketislemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_Tip;
        private System.Windows.Forms.TextBox textBox_Bfiyat;
        private System.Windows.Forms.TextBox textBox_Miktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Urun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}