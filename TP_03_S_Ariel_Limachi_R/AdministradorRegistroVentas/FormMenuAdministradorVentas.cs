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
    public partial class FormMenuAdministradorVentas : Form
    {
        AdministracionVentas registroActual;
        public FormMenuAdministradorVentas(AdministracionVentas registro)
        {
            this.registroActual = registro;
            InitializeComponent();
        }

        private void FormMenuAdministradorVentas_Load(object sender, EventArgs e)
        {
            
            this.dgvListaRegistros.DataSource = registroActual.facturacion;
            if (registroActual.facturacion.Count > 0)
            {
                this.dgvListaRegistros.Columns[4].Visible = false;
                this.dgvListaRegistros.Columns[5].Visible = false;
                this.dgvListaRegistros.Columns[1].Width = 170;
                this.dgvListaRegistros.Columns[0].Width = 85;
                this.dgvListaRegistros.Columns[2].Width = 85;
                this.dgvListaRegistros.Columns[3].Width = 170;
            }
            
            this.txtNroRegistros.Text = registroActual.facturacion.Count.ToString();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNuevoRegistro aux = new FormNuevoRegistro(registroActual);
            aux.ShowDialog();
            this.dgvListaRegistros.DataSource = null;
            this.dgvListaRegistros.DataSource = registroActual.facturacion;
            this.dgvListaRegistros.Columns[4].Visible = false;
            this.dgvListaRegistros.Columns[5].Visible = false;
            this.dgvListaRegistros.Columns[1].Width = 170;
            this.dgvListaRegistros.Columns[0].Width = 85;
            this.dgvListaRegistros.Columns[2].Width = 85;
            this.dgvListaRegistros.Columns[3].Width = 170;
            this.txtNroRegistros.Text = registroActual.facturacion.Count.ToString();
            this.Show();
        }

        private void btnInformeLocalidades_Click(object sender, EventArgs e)
        {
            FormInforme info = new FormInforme(registroActual.InformeLocalidadVentas());
            info.ShowDialog();
        }

        private void BtnInformeProdVendidosMeses_Click(object sender, EventArgs e)
        {
            FormInforme info = new FormInforme(registroActual.InformeProductosVendidosxMeses());
            info.ShowDialog();
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            FormGuardarRegistro aux = new FormGuardarRegistro(this.registroActual);
            aux.ShowDialog();
        }

        private void dgvListaRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInformeVendedores_Click(object sender, EventArgs e)
        {
            FormInforme info = new FormInforme(registroActual.InformeVentasAllVendedores());
            info.ShowDialog();
        }
    }
}
