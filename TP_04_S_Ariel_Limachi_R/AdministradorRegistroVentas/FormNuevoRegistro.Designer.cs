
namespace AdministradorRegistroVentas
{
    partial class FormNuevoRegistro
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
            this.txtNombreCte = new System.Windows.Forms.TextBox();
            this.txtApellidoCte = new System.Windows.Forms.TextBox();
            this.txtCuilCte = new System.Windows.Forms.TextBox();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.txtApellidoVendedor = new System.Windows.Forms.TextBox();
            this.txtCuilVendedor = new System.Windows.Forms.TextBox();
            this.cmbListaProductos = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLocalidadCte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombreCte
            // 
            this.txtNombreCte.Location = new System.Drawing.Point(131, 56);
            this.txtNombreCte.Name = "txtNombreCte";
            this.txtNombreCte.Size = new System.Drawing.Size(128, 23);
            this.txtNombreCte.TabIndex = 0;
            // 
            // txtApellidoCte
            // 
            this.txtApellidoCte.Location = new System.Drawing.Point(131, 85);
            this.txtApellidoCte.Name = "txtApellidoCte";
            this.txtApellidoCte.Size = new System.Drawing.Size(128, 23);
            this.txtApellidoCte.TabIndex = 1;
            // 
            // txtCuilCte
            // 
            this.txtCuilCte.Location = new System.Drawing.Point(131, 114);
            this.txtCuilCte.Name = "txtCuilCte";
            this.txtCuilCte.Size = new System.Drawing.Size(128, 23);
            this.txtCuilCte.TabIndex = 2;
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(328, 56);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.ReadOnly = true;
            this.txtNombreVendedor.Size = new System.Drawing.Size(127, 23);
            this.txtNombreVendedor.TabIndex = 6;
            this.txtNombreVendedor.Text = "Alice";
            // 
            // txtApellidoVendedor
            // 
            this.txtApellidoVendedor.Location = new System.Drawing.Point(328, 87);
            this.txtApellidoVendedor.Name = "txtApellidoVendedor";
            this.txtApellidoVendedor.ReadOnly = true;
            this.txtApellidoVendedor.Size = new System.Drawing.Size(127, 23);
            this.txtApellidoVendedor.TabIndex = 7;
            this.txtApellidoVendedor.Text = "Ramos";
            // 
            // txtCuilVendedor
            // 
            this.txtCuilVendedor.Location = new System.Drawing.Point(328, 114);
            this.txtCuilVendedor.Name = "txtCuilVendedor";
            this.txtCuilVendedor.ReadOnly = true;
            this.txtCuilVendedor.Size = new System.Drawing.Size(127, 23);
            this.txtCuilVendedor.TabIndex = 8;
            this.txtCuilVendedor.Text = "27404040402";
            // 
            // cmbListaProductos
            // 
            this.cmbListaProductos.FormattingEnabled = true;
            this.cmbListaProductos.Items.AddRange(new object[] {
            "Lista Harcodeada 1",
            "Lista Harcodeada 2",
            "Lista Harcodeada 3"});
            this.cmbListaProductos.Location = new System.Drawing.Point(179, 189);
            this.cmbListaProductos.Name = "cmbListaProductos";
            this.cmbListaProductos.Size = new System.Drawing.Size(276, 23);
            this.cmbListaProductos.TabIndex = 6;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(59, 218);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(160, 23);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(287, 218);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cuil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cuil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lista de Productos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Datos Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Datos Vendedor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Localidad";
            // 
            // txtLocalidadCte
            // 
            this.txtLocalidadCte.Location = new System.Drawing.Point(131, 149);
            this.txtLocalidadCte.Name = "txtLocalidadCte";
            this.txtLocalidadCte.Size = new System.Drawing.Size(128, 23);
            this.txtLocalidadCte.TabIndex = 4;
            // 
            // FormNuevoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 262);
            this.Controls.Add(this.txtLocalidadCte);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cmbListaProductos);
            this.Controls.Add(this.txtCuilVendedor);
            this.Controls.Add(this.txtApellidoVendedor);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.txtCuilCte);
            this.Controls.Add(this.txtApellidoCte);
            this.Controls.Add(this.txtNombreCte);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNuevoRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNuevoRegistro";
            this.Load += new System.EventHandler(this.FormNuevoRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCte;
        private System.Windows.Forms.TextBox txtApellidoCte;
        private System.Windows.Forms.TextBox txtCuilCte;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.TextBox txtApellidoVendedor;
        private System.Windows.Forms.TextBox txtCuilVendedor;
        private System.Windows.Forms.ComboBox cmbListaProductos;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLocalidadCte;
    }
}