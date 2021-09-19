using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FromMenuCerrar : Form
    {
        public FromMenuCerrar()
        {
            InitializeComponent();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            Dispose();
            DialogResult = DialogResult.Yes;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Dispose();
            DialogResult = DialogResult.No;
        }
    }
}
