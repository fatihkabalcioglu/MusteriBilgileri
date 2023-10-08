namespace MusteriBilgileri
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnListeyeDon = new Button();
            btnKaydet = new Button();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            nudYas = new NumericUpDown();
            label5 = new Label();
            txtAd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudYas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 72);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 128);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 184);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 0;
            label3.Text = "Yaş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 261);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 0;
            label4.Text = "Adres";
            // 
            // btnListeyeDon
            // 
            btnListeyeDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListeyeDon.Location = new Point(111, 475);
            btnListeyeDon.Name = "btnListeyeDon";
            btnListeyeDon.Size = new Size(220, 62);
            btnListeyeDon.TabIndex = 1;
            btnListeyeDon.Text = "Listeye Dön";
            btnListeyeDon.UseVisualStyleBackColor = true;
            btnListeyeDon.Click += btnListeyeDon_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(111, 408);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(220, 61);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(111, 69);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(220, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(111, 125);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(220, 27);
            txtTelefon.TabIndex = 2;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(111, 261);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(220, 116);
            txtAdres.TabIndex = 2;
            // 
            // nudYas
            // 
            nudYas.Location = new Point(111, 182);
            nudYas.Name = "nudYas";
            nudYas.Size = new Size(220, 27);
            nudYas.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 25);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 0;
            label5.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(111, 25);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(220, 27);
            txtAd.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 549);
            Controls.Add(nudYas);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(btnKaydet);
            Controls.Add(btnListeyeDon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Bilgiler";
            ((System.ComponentModel.ISupportInitialize)nudYas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnListeyeDon;
        private Button btnKaydet;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private NumericUpDown nudYas;
        private Label label5;
        private TextBox txtAd;
    }
}