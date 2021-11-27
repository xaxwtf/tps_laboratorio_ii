
namespace AdministradorRegistroVentas
{
    partial class FormInforme
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
            this.rtxtbInforme = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtbInforme
            // 
            this.rtxtbInforme.Location = new System.Drawing.Point(12, 12);
            this.rtxtbInforme.Name = "rtxtbInforme";
            this.rtxtbInforme.Size = new System.Drawing.Size(946, 325);
            this.rtxtbInforme.TabIndex = 0;
            this.rtxtbInforme.Text = "";
            // 
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 347);
            this.Controls.Add(this.rtxtbInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInforme";
            this.Load += new System.EventHandler(this.FormInforme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtbInforme;
    }
}