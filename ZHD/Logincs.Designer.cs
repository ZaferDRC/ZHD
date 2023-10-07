namespace ZHD
{
    partial class Logincs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logincs));
            this.kullAd_Txt = new System.Windows.Forms.TextBox();
            this.giris_Btn = new System.Windows.Forms.Button();
            this.sifre_Txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullAd_Txt
            // 
            this.kullAd_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullAd_Txt.Location = new System.Drawing.Point(912, 354);
            this.kullAd_Txt.Name = "kullAd_Txt";
            this.kullAd_Txt.Size = new System.Drawing.Size(246, 30);
            this.kullAd_Txt.TabIndex = 0;
            this.kullAd_Txt.Enter += new System.EventHandler(this.kullAd_Txt_Enter);
            this.kullAd_Txt.Leave += new System.EventHandler(this.kullAd_Txt_Leave);
            // 
            // giris_Btn
            // 
            this.giris_Btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris_Btn.Location = new System.Drawing.Point(912, 489);
            this.giris_Btn.Name = "giris_Btn";
            this.giris_Btn.Size = new System.Drawing.Size(246, 39);
            this.giris_Btn.TabIndex = 1;
            this.giris_Btn.Text = "GİRİŞ YAP";
            this.giris_Btn.UseVisualStyleBackColor = true;
            // 
            // sifre_Txt
            // 
            this.sifre_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_Txt.Location = new System.Drawing.Point(912, 417);
            this.sifre_Txt.Name = "sifre_Txt";
            this.sifre_Txt.Size = new System.Drawing.Size(246, 30);
            this.sifre_Txt.TabIndex = 2;
            this.sifre_Txt.Enter += new System.EventHandler(this.sifre_Txt_Enter);
            this.sifre_Txt.Leave += new System.EventHandler(this.sifre_Txt_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(816, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(864, 949);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Copyright © 2023 Tüm Hakları Saklıdır";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(881, 855);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "-ZHD BİLİŞİM TEKNOLOJİLERİ-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(978, 878);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "since 2023";
            // 
            // Logincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sifre_Txt);
            this.Controls.Add(this.giris_Btn);
            this.Controls.Add(this.kullAd_Txt);
            this.Name = "Logincs";
            this.Text = "Logincs";
            this.Load += new System.EventHandler(this.Logincs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullAd_Txt;
        private System.Windows.Forms.Button giris_Btn;
        private System.Windows.Forms.TextBox sifre_Txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}