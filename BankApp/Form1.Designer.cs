namespace OOP_Banka_ZaferHoca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBankaOlustur = new System.Windows.Forms.Button();
            this.btnMusteriGeldi = new System.Windows.Forms.Button();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.cmbIslemTipi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblİslemTipi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBankaOlustur
            // 
            this.btnBankaOlustur.Location = new System.Drawing.Point(40, 28);
            this.btnBankaOlustur.Name = "btnBankaOlustur";
            this.btnBankaOlustur.Size = new System.Drawing.Size(178, 59);
            this.btnBankaOlustur.TabIndex = 1;
            this.btnBankaOlustur.Text = "Banka Oluştur";
            this.btnBankaOlustur.UseVisualStyleBackColor = true;
            this.btnBankaOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMusteriGeldi
            // 
            this.btnMusteriGeldi.Location = new System.Drawing.Point(268, 78);
            this.btnMusteriGeldi.Name = "btnMusteriGeldi";
            this.btnMusteriGeldi.Size = new System.Drawing.Size(178, 54);
            this.btnMusteriGeldi.TabIndex = 2;
            this.btnMusteriGeldi.Text = "Müşteri Geldi";
            this.btnMusteriGeldi.UseVisualStyleBackColor = true;
            this.btnMusteriGeldi.Click += new System.EventHandler(this.btnMusteriGeldi_Click);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(131, 35);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(315, 23);
            this.txtTcNo.TabIndex = 3;
            // 
            // cmbIslemTipi
            // 
            this.cmbIslemTipi.FormattingEnabled = true;
            this.cmbIslemTipi.Location = new System.Drawing.Point(131, 95);
            this.cmbIslemTipi.Name = "cmbIslemTipi";
            this.cmbIslemTipi.Size = new System.Drawing.Size(121, 23);
            this.cmbIslemTipi.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblİslemTipi);
            this.groupBox1.Controls.Add(this.lblMusteri);
            this.groupBox1.Controls.Add(this.btnMusteriGeldi);
            this.groupBox1.Controls.Add(this.cmbIslemTipi);
            this.groupBox1.Controls.Add(this.txtTcNo);
            this.groupBox1.Location = new System.Drawing.Point(34, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 373);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(16, 38);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(86, 15);
            this.lblMusteri.TabIndex = 5;
            this.lblMusteri.Tag = " ";
            this.lblMusteri.Text = "Müsteri Tc No :";
            // 
            // lblİslemTipi
            // 
            this.lblİslemTipi.AutoSize = true;
            this.lblİslemTipi.Location = new System.Drawing.Point(16, 98);
            this.lblİslemTipi.Name = "lblİslemTipi";
            this.lblİslemTipi.Size = new System.Drawing.Size(64, 15);
            this.lblİslemTipi.TabIndex = 5;
            this.lblİslemTipi.Text = "İşlem tipi : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 617);
            this.Controls.Add(this.btnBankaOlustur);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnBankaOlustur;
        private Button btnMusteriGeldi;
        private TextBox txtTcNo;
        private ComboBox cmbIslemTipi;
        private GroupBox groupBox1;
        private Label lblİslemTipi;
        private Label lblMusteri;
    }
}