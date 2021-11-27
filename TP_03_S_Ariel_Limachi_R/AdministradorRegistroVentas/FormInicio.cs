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
    public partial class FromInicio : Form
    {
        AdministracionVentas ventas = new AdministracionVentas();
        public FromInicio()
        {
            InitializeComponent();
            GeneradorRegistro.HarcodearCarpetaEInfo();
        }

        private void btnAutoCompletar_Click(object sender, EventArgs e)
        {
            this.txtNombreArchivo.Text = "petshop.xml";

        }

        private void btnCargarDatosArchivo_Click(object sender, EventArgs e)
        {
            try
            {

                if (ventas.CargarRegistros(this.txtNombreArchivo.Text))
                {
                    FormMenuAdministradorVentas menu = new FormMenuAdministradorVentas(ventas);
                    this.Hide();
                    menu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Error, el archivo no existe!!!! \n *recuerde que debe estar dentro de la carpeta que esta en el escritorio");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                FormMenuAdministradorVentas menu = new FormMenuAdministradorVentas(ventas);
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Show();
            }
            
            
        }
    }
}
