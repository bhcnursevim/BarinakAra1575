namespace Barinak
{
    partial class YeniEkleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.cbEngel = new System.Windows.Forms.CheckBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yaşı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Türü :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(95, 37);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(137, 20);
            this.txtAd.TabIndex = 5;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(95, 77);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(137, 20);
            this.txtYas.TabIndex = 6;
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(95, 115);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(137, 21);
            this.cmbTur.TabIndex = 7;
            // 
            // cbEngel
            // 
            this.cbEngel.AutoSize = true;
            this.cbEngel.Location = new System.Drawing.Point(32, 160);
            this.cbEngel.Name = "cbEngel";
            this.cbEngel.Size = new System.Drawing.Size(93, 17);
            this.cbEngel.TabIndex = 8;
            this.cbEngel.Text = "Engel Durumu";
            this.cbEngel.UseVisualStyleBackColor = true;
            // 
            // pbResim
            // 
            this.pbResim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbResim.Location = new System.Drawing.Point(256, 37);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(144, 171);
            this.pbResim.TabIndex = 9;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lime;
            this.btnEkle.Location = new System.Drawing.Point(12, 202);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(113, 37);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // YeniEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(427, 264);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.cbEngel);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniEkleForm";
            this.Text = "YeniEkleForm";
            this.Load += new System.EventHandler(this.YeniEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.CheckBox cbEngel;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnEkle;
    }
}