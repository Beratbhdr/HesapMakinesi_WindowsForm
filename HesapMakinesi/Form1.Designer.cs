namespace HesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_ekransonuc = new System.Windows.Forms.Label();
            this.txt_rakam1 = new System.Windows.Forms.Button();
            this.txt_rakam2 = new System.Windows.Forms.Button();
            this.txt_rakam3 = new System.Windows.Forms.Button();
            this.txt_rakam4 = new System.Windows.Forms.Button();
            this.txt_rakam5 = new System.Windows.Forms.Button();
            this.txt_rakam6 = new System.Windows.Forms.Button();
            this.txt_rakam7 = new System.Windows.Forms.Button();
            this.txt_rakam8 = new System.Windows.Forms.Button();
            this.txt_rakam9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.txt_Ciptal = new System.Windows.Forms.Button();
            this.txt_esittir = new System.Windows.Forms.Button();
            this.txt_bolme = new System.Windows.Forms.Button();
            this.txt_carpma = new System.Windows.Forms.Button();
            this.txt_cıkarma = new System.Windows.Forms.Button();
            this.txt_toplama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ekransonuc
            // 
            this.txt_ekransonuc.BackColor = System.Drawing.Color.White;
            this.txt_ekransonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ekransonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ekransonuc.Location = new System.Drawing.Point(12, 9);
            this.txt_ekransonuc.Name = "txt_ekransonuc";
            this.txt_ekransonuc.Size = new System.Drawing.Size(318, 76);
            this.txt_ekransonuc.TabIndex = 0;
            this.txt_ekransonuc.Text = "0";
            this.txt_ekransonuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_rakam1
            // 
            this.txt_rakam1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_rakam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_rakam1.Location = new System.Drawing.Point(12, 88);
            this.txt_rakam1.Name = "txt_rakam1";
            this.txt_rakam1.Size = new System.Drawing.Size(75, 75);
            this.txt_rakam1.TabIndex = 1;
            this.txt_rakam1.Text = "1";
            this.txt_rakam1.UseVisualStyleBackColor = false;
            this.txt_rakam1.Click += new System.EventHandler(this.txt_rakam1_Click);
            // 
            // txt_rakam2
            // 
            this.txt_rakam2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_rakam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_rakam2.Location = new System.Drawing.Point(93, 88);
            this.txt_rakam2.Name = "txt_rakam2";
            this.txt_rakam2.Size = new System.Drawing.Size(75, 75);
            this.txt_rakam2.TabIndex = 2;
            this.txt_rakam2.Text = "2";
            this.txt_rakam2.UseVisualStyleBackColor = false;
            this.txt_rakam2.Click += new System.EventHandler(this.txt_rakam2_Click);
            // 
            // txt_rakam3
            // 
            this.txt_rakam3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_rakam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_rakam3.Location = new System.Drawing.Point(174, 88);
            this.txt_rakam3.Name = "txt_rakam3";
            this.txt_rakam3.Size = new System.Drawing.Size(75, 75);
            this.txt_rakam3.TabIndex = 3;
            this.txt_rakam3.Text = "3";
            this.txt_rakam3.UseVisualStyleBackColor = false;
            this.txt_rakam3.Click += new System.EventHandler(this.txt_rakam3_Click);
            // 
            // txt_rakam4
            // 
            this.txt_rakam4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_rakam4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_rakam4.Location = new System.Drawing.Point(12, 169);
            this.txt_rakam4.Name = "txt_rakam4";
            this.txt_rakam4.Size = new System.Drawing.Size(75, 75);
            this.txt_rakam4.TabIndex = 4;
            this.txt_rakam4.Text = "4";
            this.txt_rakam4.UseVisualStyleBackColor = false;
            this.txt_rakam4.Click += new System.EventHandler(this.txt_rakam4_Click);
            // 
            // txt_rakam5
            // 
            this.txt_rakam5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_rakam5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_rakam5.Location = new System.Drawing.Point(93, 169);
            this.txt_rakam5.Name = "txt_rakam5";
            this.txt_rakam5.Size = new System.Drawing.Size(75, 75);
            this.txt_rakam5.TabIndex = 5;
            this.txt_rakam5.Text = "5";
            this.txt_rakam5.UseVisualStyleBackColor = false;
            this.txt_rakam5.Click += new System.EventHandler(this.txt_rakam5_Click);
            // 
            // txt_rakam6
            // 
            this.txt_rakam6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_rakam6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_rakam6.Location = new System.Drawing.Point(174, 169);
            this.txt_rakam6.Name = "txt_rakam6";
            this.txt_rakam6.Size = new System.Drawing.Size(75, 75);
            this.txt_rakam6.TabIndex = 6;
            this.txt_rakam6.Text = "6";
            this.txt_rakam6.UseVisualStyleBackColor = false;
            this.txt_rakam6.Click += new System.EventHandler(this.txt_rakam6_Click);
            // 
            // txt_rakam7
            // 
            this.txt_rakam7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_rakam7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_rakam7.Location = new System.Drawing.Point(12, 250);
            this.txt_rakam7.Name = "txt_rakam7";
            this.txt_rakam7.Size = new System.Drawing.Size(75, 75);
            this.txt_rakam7.TabIndex = 7;
            this.txt_rakam7.Text = "7";
            this.txt_rakam7.UseVisualStyleBackColor = false;
            this.txt_rakam7.Click += new System.EventHandler(this.txt_rakam7_Click);
            // 
            // txt_rakam8
            // 
            this.txt_rakam8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_rakam8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_rakam8.Location = new System.Drawing.Point(93, 250);
            this.txt_rakam8.Name = "txt_rakam8";
            this.txt_rakam8.Size = new System.Drawing.Size(75, 75);
            this.txt_rakam8.TabIndex = 8;
            this.txt_rakam8.Text = "8";
            this.txt_rakam8.UseVisualStyleBackColor = false;
            this.txt_rakam8.Click += new System.EventHandler(this.txt_rakam8_Click);
            // 
            // txt_rakam9
            // 
            this.txt_rakam9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_rakam9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_rakam9.Location = new System.Drawing.Point(174, 250);
            this.txt_rakam9.Name = "txt_rakam9";
            this.txt_rakam9.Size = new System.Drawing.Size(75, 75);
            this.txt_rakam9.TabIndex = 9;
            this.txt_rakam9.Text = "9";
            this.txt_rakam9.UseVisualStyleBackColor = false;
            this.txt_rakam9.Click += new System.EventHandler(this.txt_rakam9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(93, 330);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 75);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // txt_Ciptal
            // 
            this.txt_Ciptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_Ciptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ciptal.Location = new System.Drawing.Point(12, 330);
            this.txt_Ciptal.Name = "txt_Ciptal";
            this.txt_Ciptal.Size = new System.Drawing.Size(75, 75);
            this.txt_Ciptal.TabIndex = 11;
            this.txt_Ciptal.Text = "C";
            this.txt_Ciptal.UseVisualStyleBackColor = false;
            this.txt_Ciptal.Click += new System.EventHandler(this.txt_Ciptal_Click);
            // 
            // txt_esittir
            // 
            this.txt_esittir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_esittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_esittir.Location = new System.Drawing.Point(174, 331);
            this.txt_esittir.Name = "txt_esittir";
            this.txt_esittir.Size = new System.Drawing.Size(75, 75);
            this.txt_esittir.TabIndex = 12;
            this.txt_esittir.Text = "=";
            this.txt_esittir.UseVisualStyleBackColor = false;
            this.txt_esittir.Click += new System.EventHandler(this.txt_esittir_Click);
            // 
            // txt_bolme
            // 
            this.txt_bolme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bolme.Location = new System.Drawing.Point(255, 331);
            this.txt_bolme.Name = "txt_bolme";
            this.txt_bolme.Size = new System.Drawing.Size(75, 75);
            this.txt_bolme.TabIndex = 16;
            this.txt_bolme.Text = "/";
            this.txt_bolme.UseVisualStyleBackColor = false;
            this.txt_bolme.Click += new System.EventHandler(this.txt_bolme_Click);
            // 
            // txt_carpma
            // 
            this.txt_carpma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_carpma.Location = new System.Drawing.Point(255, 250);
            this.txt_carpma.Name = "txt_carpma";
            this.txt_carpma.Size = new System.Drawing.Size(75, 75);
            this.txt_carpma.TabIndex = 15;
            this.txt_carpma.Text = "X";
            this.txt_carpma.UseVisualStyleBackColor = false;
            this.txt_carpma.Click += new System.EventHandler(this.txt_carpma_Click);
            // 
            // txt_cıkarma
            // 
            this.txt_cıkarma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_cıkarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_cıkarma.Location = new System.Drawing.Point(255, 169);
            this.txt_cıkarma.Name = "txt_cıkarma";
            this.txt_cıkarma.Size = new System.Drawing.Size(75, 75);
            this.txt_cıkarma.TabIndex = 14;
            this.txt_cıkarma.Text = "-";
            this.txt_cıkarma.UseVisualStyleBackColor = false;
            this.txt_cıkarma.Click += new System.EventHandler(this.txt_cıkarma_Click);
            // 
            // txt_toplama
            // 
            this.txt_toplama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplama.Location = new System.Drawing.Point(255, 88);
            this.txt_toplama.Name = "txt_toplama";
            this.txt_toplama.Size = new System.Drawing.Size(75, 75);
            this.txt_toplama.TabIndex = 13;
            this.txt_toplama.Text = "+";
            this.txt_toplama.UseVisualStyleBackColor = false;
            this.txt_toplama.Click += new System.EventHandler(this.txt_toplama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(345, 417);
            this.Controls.Add(this.txt_bolme);
            this.Controls.Add(this.txt_carpma);
            this.Controls.Add(this.txt_cıkarma);
            this.Controls.Add(this.txt_toplama);
            this.Controls.Add(this.txt_esittir);
            this.Controls.Add(this.txt_Ciptal);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.txt_rakam9);
            this.Controls.Add(this.txt_rakam8);
            this.Controls.Add(this.txt_rakam7);
            this.Controls.Add(this.txt_rakam6);
            this.Controls.Add(this.txt_rakam5);
            this.Controls.Add(this.txt_rakam4);
            this.Controls.Add(this.txt_rakam3);
            this.Controls.Add(this.txt_rakam2);
            this.Controls.Add(this.txt_rakam1);
            this.Controls.Add(this.txt_ekransonuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HESAP MAKİNESİ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt_ekransonuc;
        private System.Windows.Forms.Button txt_rakam1;
        private System.Windows.Forms.Button txt_rakam2;
        private System.Windows.Forms.Button txt_rakam3;
        private System.Windows.Forms.Button txt_rakam4;
        private System.Windows.Forms.Button txt_rakam5;
        private System.Windows.Forms.Button txt_rakam6;
        private System.Windows.Forms.Button txt_rakam7;
        private System.Windows.Forms.Button txt_rakam8;
        private System.Windows.Forms.Button txt_rakam9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button txt_Ciptal;
        private System.Windows.Forms.Button txt_esittir;
        private System.Windows.Forms.Button txt_bolme;
        private System.Windows.Forms.Button txt_carpma;
        private System.Windows.Forms.Button txt_cıkarma;
        private System.Windows.Forms.Button txt_toplama;
    }
}

