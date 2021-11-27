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
    public partial class FormInforme : Form
    {
        string information;
        public FormInforme(string informe)
        {
            InitializeComponent();
            this.information = informe;
        }

        private void FormInforme_Load(object sender, EventArgs e)
        {
            this.rtxtbInforme.Text = information;
            this.Text = "Informe";
        }
    }
}
