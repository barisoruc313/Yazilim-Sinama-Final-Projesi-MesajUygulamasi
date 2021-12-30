
namespace MesajUygulama
{
    partial class SifreliDosyaForm
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
            this.rbSifrele = new System.Windows.Forms.RadioButton();
            this.rbCoz = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtSifre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtOutput = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUygula = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCompress = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // rbSifrele
            // 
            this.rbSifrele.AutoSize = true;
            this.rbSifrele.Location = new System.Drawing.Point(284, 252);
            this.rbSifrele.Margin = new System.Windows.Forms.Padding(4);
            this.rbSifrele.Name = "rbSifrele";
            this.rbSifrele.Size = new System.Drawing.Size(69, 21);
            this.rbSifrele.TabIndex = 5;
            this.rbSifrele.TabStop = true;
            this.rbSifrele.Text = "Şifrele";
            this.rbSifrele.UseVisualStyleBackColor = true;
            this.rbSifrele.CheckedChanged += new System.EventHandler(this.rbSifrele_CheckedChanged);
            // 
            // rbCoz
            // 
            this.rbCoz.AutoSize = true;
            this.rbCoz.Location = new System.Drawing.Point(427, 252);
            this.rbCoz.Margin = new System.Windows.Forms.Padding(4);
            this.rbCoz.Name = "rbCoz";
            this.rbCoz.Size = new System.Drawing.Size(82, 21);
            this.rbCoz.TabIndex = 6;
            this.rbCoz.TabStop = true;
            this.rbCoz.Text = "ŞifreÇöz";
            this.rbCoz.UseVisualStyleBackColor = true;
            this.rbCoz.CheckedChanged += new System.EventHandler(this.rbCoz_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(156, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre :";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(136, 72);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(472, 99);
            this.txtInput.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtInput.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtInput.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtInput.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtInput.StateCommon.Border.Rounding = 20;
            this.txtInput.StateCommon.Border.Width = 1;
            this.txtInput.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInput.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInput.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtInput.TabIndex = 11;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(147, 187);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnBrowse.Size = new System.Drawing.Size(119, 40);
            this.btnBrowse.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBrowse.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBrowse.StateCommon.Back.ColorAngle = 45F;
            this.btnBrowse.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBrowse.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBrowse.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBrowse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBrowse.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBrowse.StateCommon.Border.Rounding = 20;
            this.btnBrowse.StateCommon.Border.Width = 1;
            this.btnBrowse.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBrowse.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Values.Text = "Dosya Ekle";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(147, 295);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(224, 37);
            this.txtSifre.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSifre.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSifre.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtSifre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSifre.StateCommon.Border.Rounding = 20;
            this.txtSifre.StateCommon.Border.Width = 1;
            this.txtSifre.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifre.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSifre.TabIndex = 13;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(393, 416);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(215, 37);
            this.txtOutput.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtOutput.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOutput.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtOutput.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtOutput.StateCommon.Border.Rounding = 20;
            this.txtOutput.StateCommon.Border.Width = 1;
            this.txtOutput.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOutput.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOutput.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtOutput.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(142, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sıkıştırılan Dosya :";
            // 
            // btnUygula
            // 
            this.btnUygula.Location = new System.Drawing.Point(377, 295);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnUygula.Size = new System.Drawing.Size(119, 40);
            this.btnUygula.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUygula.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUygula.StateCommon.Back.ColorAngle = 45F;
            this.btnUygula.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUygula.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUygula.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUygula.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUygula.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUygula.StateCommon.Border.Rounding = 20;
            this.btnUygula.StateCommon.Border.Width = 1;
            this.btnUygula.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUygula.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUygula.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUygula.TabIndex = 16;
            this.btnUygula.Values.Text = "Uygula";
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click_1);
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(489, 355);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCompress.Size = new System.Drawing.Size(119, 40);
            this.btnCompress.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCompress.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCompress.StateCommon.Back.ColorAngle = 45F;
            this.btnCompress.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCompress.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCompress.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCompress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCompress.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCompress.StateCommon.Border.Rounding = 20;
            this.btnCompress.StateCommon.Border.Width = 1;
            this.btnCompress.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCompress.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCompress.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompress.TabIndex = 17;
            this.btnCompress.Values.Text = "Sıkıştır";
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click_1);
            // 
            // SifreliDosyaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 551);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbCoz);
            this.Controls.Add(this.rbSifrele);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SifreliDosyaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreliDosyaForm";
            this.Load += new System.EventHandler(this.SifreliDosyaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbSifrele;
        private System.Windows.Forms.RadioButton rbCoz;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtInput;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBrowse;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSifre;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOutput;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUygula;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCompress;
    }
}