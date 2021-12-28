
namespace MesajUygulama
{
    partial class Sha256Form
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
            this.txtSifrelenen = new System.Windows.Forms.TextBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesaj :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifrelenen :";
            // 
            // txtSifrelenen
            // 
            this.txtSifrelenen.Location = new System.Drawing.Point(92, 151);
            this.txtSifrelenen.Multiline = true;
            this.txtSifrelenen.Name = "txtSifrelenen";
            this.txtSifrelenen.Size = new System.Drawing.Size(161, 134);
            this.txtSifrelenen.TabIndex = 2;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(92, 34);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(161, 20);
            this.txtMesaj.TabIndex = 3;
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(178, 60);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(75, 23);
            this.btnSifrele.TabIndex = 4;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // Sha256Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 317);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.txtSifrelenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sha256Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sha256Form";
            this.Load += new System.EventHandler(this.Sha256Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifrelenen;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnSifrele;
    }
}