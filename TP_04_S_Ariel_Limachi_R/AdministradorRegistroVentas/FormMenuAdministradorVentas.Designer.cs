
namespace AdministradorRegistroVentas
{
    partial class FormMenuAdministradorVentas
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
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnInformeLocalidades = new System.Windows.Forms.Button();
            this.btnInformeVendedores = new System.Windows.Forms.Button();
            this.BtnInformeProdVendidosMeses = new System.Windows.Forms.Button();
            this.txtNroRegistros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaRegistros = new System.Windows.Forms.DataGridView();
            this.btnGuardarRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Location = new System.Drawing.Point(178, 268);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(102, 23);
            this.btnAgregarRegistro.TabIndex = 0;
            this.btnAgregarRegistro.Text = "Añadir Registro";
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnInformeLocalidades
            // 
            this.btnInformeLocalidades.Location = new System.Drawing.Point(12, 44);
            this.btnInformeLocalidades.Name = "btnInformeLocalidades";
            this.btnInformeLocalidades.Size = new System.Drawing.Size(160, 56);
            this.btnInformeLocalidades.TabIndex = 1;
            this.btnInformeLocalidades.Text = "Informe Localidades";
            this.btnInformeLocalidades.UseVisualStyleBackColor = true;
            this.btnInformeLocalidades.Click += new System.EventHandler(this.btnInformeLocalidades_Click);
            // 
            // btnInformeVendedores
            // 
            this.btnInformeVendedores.Location = new System.Drawing.Point(12, 117);
            this.btnInformeVendedores.Name = "btnInformeVendedores";
            this.btnInformeVendedores.Size = new System.Drawing.Size(160, 57);
            this.btnInformeVendedores.TabIndex = 2;
            this.btnInformeVendedores.Text = "Informe Vendedores";
            this.btnInformeVendedores.UseVisualStyleBackColor = true;
            this.btnInformeVendedores.Click += new System.EventHandler(this.btnInformeVendedores_Click);
            // 
            // BtnInformeProdVendidosMeses
            // 
            this.BtnInformeProdVendidosMeses.Location = new System.Drawing.Point(12, 189);
            this.BtnInformeProdVendidosMeses.Name = "BtnInformeProdVendidosMeses";
            this.BtnInformeProdVendidosMeses.Size = new System.Drawing.Size(160, 52);
            this.BtnInformeProdVendidosMeses.TabIndex = 3;
            this.BtnInformeProdVendidosMeses.Text = "Informe Productos Vendidos Por Meses";
            this.BtnInformeProdVendidosMeses.UseVisualStyleBackColor = true;
            this.BtnInformeProdVendidosMeses.Click += new System.EventHandler(this.BtnInformeProdVendidosMeses_Click);
            // 
            // txtNroRegistros
            // 
            this.txtNroRegistros.Location = new System.Drawing.Point(278, 18);
            this.txtNroRegistros.Name = "txtNroRegistros";
            this.txtNroRegistros.ReadOnly = true;
            this.txtNroRegistros.Size = new System.Drawing.Size(100, 23);
            this.txtNroRegistros.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nro de Registros";
            // 
            // dgvListaRegistros
            // 
            this.dgvListaRegistros.AllowUserToAddRows = false;
            this.dgvListaRegistros.AllowUserToDeleteRows = false;
            this.dgvListaRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRegistros.Location = new System.Drawing.Point(178, 44);
            this.dgvListaRegistros.Name = "dgvListaRegistros";
            this.dgvListaRegistros.ReadOnly = true;
            this.dgvListaRegistros.RowTemplate.Height = 25;
            this.dgvListaRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaRegistros.Size = new System.Drawing.Size(549, 197);
            this.dgvListaRegistros.TabIndex = 6;
            this.dgvListaRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaRegistros_CellContentClick);
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.Location = new System.Drawing.Point(607, 268);
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Size = new System.Drawing.Size(120, 23);
            this.btnGuardarRegistro.TabIndex = 7;
            this.btnGuardarRegistro.Text = "Guardar Registro";
            this.btnGuardarRegistro.UseVisualStyleBackColor = true;
            this.btnGuardarRegistro.Click += new System.EventHandler(this.btnGuardarRegistro_Click);
            // 
            // FormMenuAdministradorVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 307);
            this.Controls.Add(this.btnGuardarRegistro);
            this.Controls.Add(this.dgvListaRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNroRegistros);
            this.Controls.Add(this.BtnInformeProdVendidosMeses);
            this.Controls.Add(this.btnInformeVendedores);
            this.Controls.Add(this.btnInformeLocalidades);
            this.Controls.Add(this.btnAgregarRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenuAdministradorVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuAdministradorVentas";
            this.Load += new System.EventHandler(this.FormMenuAdministradorVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnInformeLocalidades;
        private System.Windows.Forms.Button btnInformeVendedores;
        private System.Windows.Forms.Button BtnInformeProdVendidosMeses;
        private System.Windows.Forms.TextBox txtNroRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaRegistros;
        private System.Windows.Forms.Button btnGuardarRegistro;
    }
}