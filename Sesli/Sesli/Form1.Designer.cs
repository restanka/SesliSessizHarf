
namespace Sesli
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
            this.tbKelimeGir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bBul = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.lbSesliHarf = new System.Windows.Forms.ListBox();
            this.lbSessizHarf = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbKelimeGir
            // 
            this.tbKelimeGir.Location = new System.Drawing.Point(105, 12);
            this.tbKelimeGir.Name = "tbKelimeGir";
            this.tbKelimeGir.Size = new System.Drawing.Size(100, 20);
            this.tbKelimeGir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelime Giriniz : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sesli Harfler :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sessiz Harfler :";
            // 
            // bBul
            // 
            this.bBul.Location = new System.Drawing.Point(91, 81);
            this.bBul.Name = "bBul";
            this.bBul.Size = new System.Drawing.Size(135, 23);
            this.bBul.TabIndex = 4;
            this.bBul.Text = "Sesli Sessiz Harfleri Ayır";
            this.bBul.UseVisualStyleBackColor = true;
            this.bBul.Click += new System.EventHandler(this.bBul_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(117, 125);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(75, 23);
            this.bTemizle.TabIndex = 5;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // lbSesliHarf
            // 
            this.lbSesliHarf.FormattingEnabled = true;
            this.lbSesliHarf.Location = new System.Drawing.Point(12, 196);
            this.lbSesliHarf.Name = "lbSesliHarf";
            this.lbSesliHarf.Size = new System.Drawing.Size(108, 121);
            this.lbSesliHarf.TabIndex = 6;
            // 
            // lbSessizHarf
            // 
            this.lbSessizHarf.FormattingEnabled = true;
            this.lbSessizHarf.Location = new System.Drawing.Point(198, 196);
            this.lbSessizHarf.Name = "lbSessizHarf";
            this.lbSessizHarf.Size = new System.Drawing.Size(120, 121);
            this.lbSessizHarf.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(330, 344);
            this.Controls.Add(this.lbSessizHarf);
            this.Controls.Add(this.lbSesliHarf);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bBul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKelimeGir);
            this.Name = "Form1";
            this.Text = "Sesli Sessiz Harf Uygulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKelimeGir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bBul;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.ListBox lbSesliHarf;
        private System.Windows.Forms.ListBox lbSessizHarf;
    }
}

