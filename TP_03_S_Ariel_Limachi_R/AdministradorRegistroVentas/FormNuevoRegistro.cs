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
using ExepcionesPropias;

namespace AdministradorRegistroVentas
{
    public partial class FormNuevoRegistro : Form
    {
        Persona vendedorGenerico;
        Factura unRegistro;
        AdministracionVentas registros;
        public FormNuevoRegistro(AdministracionVentas registro)
        {
            InitializeComponent();
            registros=registro;
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Persona nuevo = new Persona(this.txtNombreCte.Text, this.txtApellidoCte.Text, this.txtCuilCte.Text, this.txtLocalidadCte.Text);
            try
            {
                switch (this.cmbListaProductos.SelectedIndex)
                {
                    case -1:
                        throw new DetalleDeCompraVacioException();
                    case 0:
                        unRegistro = new Factura("2525252525", GeneradorRegistro.ListaHarcodeada1(), vendedorGenerico, nuevo);
                        unRegistro.ObtenerTotal();
                        registros.facturacion.Add(unRegistro);
                        break;
                    case 1:
                        unRegistro = new Factura("2525252525", GeneradorRegistro.ListaHarcodeada2(), vendedorGenerico, nuevo);
                        unRegistro.ObtenerTotal();
                        registros.facturacion.Add(unRegistro);
                        break;
                    case 2:
                        unRegistro = new Factura("2525252525", GeneradorRegistro.ListaHarcodeada3(), vendedorGenerico, nuevo);
                        unRegistro.ObtenerTotal();
                        registros.facturacion.Add(unRegistro);
                        break;
                }
                this.Dispose();
            }
            catch(DetalleDeCompraVacioException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormNuevoRegistro_Load(object sender, EventArgs e)
        {
             vendedorGenerico= new Persona(this.txtNombreVendedor.Text, this.txtApellidoVendedor.Text,this.txtCuilVendedor.Text, "CABA");
        }
    }
}
