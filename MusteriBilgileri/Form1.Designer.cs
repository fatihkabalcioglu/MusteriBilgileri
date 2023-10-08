namespace MusteriBilgileri
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
            lboxMusteriler = new ListBox();
            btnYeniMusteri = new Button();
            SuspendLayout();
            // 
            // lboxMusteriler
            // 
            lboxMusteriler.FormattingEnabled = true;
            lboxMusteriler.ItemHeight = 20;
            lboxMusteriler.Location = new Point(12, 12);
            lboxMusteriler.Name = "lboxMusteriler";
            lboxMusteriler.Size = new Size(441, 344);
            lboxMusteriler.TabIndex = 0;
            // 
            // btnYeniMusteri
            // 
            btnYeniMusteri.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniMusteri.Location = new Point(12, 361);
            btnYeniMusteri.Name = "btnYeniMusteri";
            btnYeniMusteri.Size = new Size(441, 77);
            btnYeniMusteri.TabIndex = 1;
            btnYeniMusteri.Text = "Yeni Müşteri Ekle";
            btnYeniMusteri.UseVisualStyleBackColor = true;
            btnYeniMusteri.Click += btnYeniMusteri_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 450);
            Controls.Add(btnYeniMusteri);
            Controls.Add(lboxMusteriler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lboxMusteriler;
        private Button btnYeniMusteri;
    }
}