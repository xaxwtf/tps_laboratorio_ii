
namespace AdministradorRegistroVentas
{
    partial class FromInicio
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
            this.btnCargarDatosArchivo = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnAutoCompletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarDatosArchivo
            // 
            this.btnCargarDatosArchivo.Location = new System.Drawing.Point(30, 74);
            this.btnCargarDatosArchivo.Name = "btnCargarDatosArchivo";
            this.btnCargarDatosArchivo.Size = new System.Drawing.Size(159, 23);
            this.btnCargarDatosArchivo.TabIndex = 0;
            this.btnCargarDatosArchivo.Text = "Cargar Desde Archivo";
            this.btnCargarDatosArchivo.UseVisualStyleBackColor = true;
            this.btnCargarDatosArchivo.Click += new System.EventHandler(this.btnCargarDatosArchivo_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(30, 45);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(159, 23);
            this.txtNombreArchivo.TabIndex = 1;
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Location = new System.Drawing.Point(30, 131);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(159, 23);
            this.btnAgregarRegistro.TabIndex = 2;
            this.btnAgregarRegistro.Text = "Crear Registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnAutoCompletar
            // 
            this.btnAutoCompletar.Location = new System.Drawing.Point(195, 35);
            this.btnAutoCompletar.Name = "btnAutoCompletar";
            this.btnAutoCompletar.Size = new System.Drawing.Size(90, 42);
            this.btnAutoCompletar.TabIndex = 3;
            this.btnAutoCompletar.Text = "Auto Compleatar";
            this.btnAutoCompletar.UseVisualStyleBackColor = true;
            this.btnAutoCompletar.Click += new System.EventHandler(this.btnAutoCompletar_Click);
            // 
            // FromInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 172);
            this.Controls.Add(this.btnAutoCompletar);
            this.Controls.Add(this.btnAgregarRegistro);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.btnCargarDatosArchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministradorVentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarDatosArchivo;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnAutoCompletar;
    }
}

