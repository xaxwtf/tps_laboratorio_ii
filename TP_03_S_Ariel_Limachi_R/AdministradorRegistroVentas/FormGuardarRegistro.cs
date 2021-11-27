using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_3_Ventas;

namespace AdministradorRegistroVentas
{
    public partial class FormGuardarRegistro : Form
    {
        AdministracionVentas registro;
        public FormGuardarRegistro(AdministracionVentas registro)
        {
            InitializeComponent();
            this.registro = registro;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (registro.SaveRegistro(this.txtNombreArchivo.Text))
            {
                MessageBox.Show("Guardado con exito");
                this.Dispose();
            }

        }

        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            if (registro.ActualizarRegistro())
            {
                MessageBox.Show("Actualizado Con exito");
                this.Dispose();
            }
        }
    }
}
