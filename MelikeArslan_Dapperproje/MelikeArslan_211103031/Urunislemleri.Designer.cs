namespace MelikeArslan_211103031
{
    partial class Urunislemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urunislemleri));
            this.button1_iptal = new System.Windows.Forms.Button();
            this.TEMİZLE = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_iptal
            // 
            this.button1_iptal.BackColor = System.Drawing.Color.Khaki;
            this.button1_iptal.Location = new System.Drawing.Point(384, 244);
            this.button1_iptal.Name = "button1_iptal";
            this.button1_iptal.Size = new System.Drawing.Size(97, 42);
            this.button1_iptal.TabIndex = 18;
            this.button1_iptal.Text = "iptal";
            this.button1_iptal.UseVisualStyleBackColor = false;
            this.button1_iptal.Click += new System.EventHandler(this.button1_iptal_Click);
            // 
            // TEMİZLE
            // 
            this.TEMİZLE.BackColor = System.Drawing.Color.Khaki;
            this.TEMİZLE.Location = new System.Drawing.Point(406, 399);
            this.TEMİZLE.Name = "TEMİZLE";
            this.TEMİZLE.Size = new System.Drawing.Size(75, 23);
            this.TEMİZLE.TabIndex = 17;
            this.TEMİZLE.Text = "TEMİZLE";
            this.TEMİZLE.UseVisualStyleBackColor = false;
            this.TEMİZLE.Click += new System.EventHandler(this.TEMİZLE_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.BackColor = System.Drawing.Color.Khaki;
            this.button_Sil.Location = new System.Drawing.Point(439, 167);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(104, 48);
            this.button_Sil.TabIndex = 16;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = false;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_ekle
            // 
            this.button_ekle.BackColor = System.Drawing.Color.Khaki;
            this.button_ekle.Location = new System.Drawing.Point(316, 167);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(104, 48);
            this.button_ekle.TabIndex = 15;
            this.button_ekle.Text = "Ekle";
            this.button_ekle.UseVisualStyleBackColor = false;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ürün Ad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(280, 397);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Urunislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(557, 449);
            this.Controls.Add(this.button1_iptal);
            this.Controls.Add(this.TEMİZLE);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Urunislemleri";
            this.Text = "Urunislemleri";
            this.Load += new System.EventHandler(this.Urunislemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_iptal;
        private System.Windows.Forms.Button TEMİZLE;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}