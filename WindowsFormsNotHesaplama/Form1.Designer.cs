namespace WindowsFormsNotHesaplama
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
            this.lbl_birinci_deger = new System.Windows.Forms.TextBox();
            this.lbl_ikinci_deger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ortalamaHesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ortalamaSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birinci değeri girin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_birinci_deger
            // 
            this.lbl_birinci_deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birinci_deger.Location = new System.Drawing.Point(251, 36);
            this.lbl_birinci_deger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbl_birinci_deger.Name = "lbl_birinci_deger";
            this.lbl_birinci_deger.Size = new System.Drawing.Size(170, 21);
            this.lbl_birinci_deger.TabIndex = 1;
            // 
            // lbl_ikinci_deger
            // 
            this.lbl_ikinci_deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ikinci_deger.Location = new System.Drawing.Point(251, 85);
            this.lbl_ikinci_deger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbl_ikinci_deger.Name = "lbl_ikinci_deger";
            this.lbl_ikinci_deger.Size = new System.Drawing.Size(170, 21);
            this.lbl_ikinci_deger.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "İkinci değeri girin";
            // 
            // btn_ortalamaHesapla
            // 
            this.btn_ortalamaHesapla.Location = new System.Drawing.Point(251, 125);
            this.btn_ortalamaHesapla.Name = "btn_ortalamaHesapla";
            this.btn_ortalamaHesapla.Size = new System.Drawing.Size(170, 38);
            this.btn_ortalamaHesapla.TabIndex = 4;
            this.btn_ortalamaHesapla.Text = "Ortalamayı Bul";
            this.btn_ortalamaHesapla.UseVisualStyleBackColor = true;
            this.btn_ortalamaHesapla.Click += new System.EventHandler(this.btn_ortalamaHesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ortalama :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_ortalamaSonuc
            // 
            this.lbl_ortalamaSonuc.AutoSize = true;
            this.lbl_ortalamaSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ortalamaSonuc.Location = new System.Drawing.Point(197, 183);
            this.lbl_ortalamaSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ortalamaSonuc.Name = "lbl_ortalamaSonuc";
            this.lbl_ortalamaSonuc.Size = new System.Drawing.Size(17, 18);
            this.lbl_ortalamaSonuc.TabIndex = 6;
            this.lbl_ortalamaSonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 224);
            this.Controls.Add(this.lbl_ortalamaSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ortalamaHesapla);
            this.Controls.Add(this.lbl_ikinci_deger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_birinci_deger);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbl_birinci_deger;
        private System.Windows.Forms.TextBox lbl_ikinci_deger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ortalamaHesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ortalamaSonuc;
    }
}

