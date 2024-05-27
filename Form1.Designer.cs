namespace EnBüyük_EnKüçük
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsayi3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtkucuk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbuyuk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1";
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(88, 44);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(100, 22);
            this.txtsayi1.TabIndex = 1;
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(88, 96);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(100, 22);
            this.txtsayi2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayı 2";
            // 
            // txtsayi3
            // 
            this.txtsayi3.Location = new System.Drawing.Point(88, 151);
            this.txtsayi3.Name = "txtsayi3";
            this.txtsayi3.Size = new System.Drawing.Size(100, 22);
            this.txtsayi3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sayı 3";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(128, 211);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(85, 27);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtkucuk
            // 
            this.txtkucuk.Location = new System.Drawing.Point(164, 334);
            this.txtkucuk.Name = "txtkucuk";
            this.txtkucuk.Size = new System.Drawing.Size(100, 22);
            this.txtkucuk.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "EN KÜÇÜK";
            // 
            // txtbuyuk
            // 
            this.txtbuyuk.Location = new System.Drawing.Point(164, 274);
            this.txtbuyuk.Name = "txtbuyuk";
            this.txtbuyuk.Size = new System.Drawing.Size(100, 22);
            this.txtbuyuk.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "EN BÜYÜK";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(216, 388);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(317, 475);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtkucuk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbuyuk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtsayi3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gamze KAŞYOL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsayi3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtkucuk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbuyuk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTemizle;
    }
}

