using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FromCalculadora : Form
    {
        Operando op1 = new Operando();
        Operando op2= new Operando();
        char aux;
        public FromCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FromMenuCerrar menu = new FromMenuCerrar();
            if (menu.ShowDialog() == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            lblResultado.Text= op1.DecimalBinario(this.txtNum1.Text);
            sb.AppendFormat("{0} -> {1}\n",  txtNum1.Text, lblResultado.Text);
            this.lstOperaciones.Items.Add(sb.ToString());
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            op1.Numero = this.txtNum1.Text;
            op2.Numero = this.txtNum2.Text;
            //aux = char.Parse(cboOperator.Text);
            if(!char.TryParse(cboOperator.Text, out aux))
            {
                aux = '+';
            }
            lblResultado.Text = Calculadora.Operar(op1, op2, aux).ToString();
            sb.AppendFormat("{0} {1} {2} = {3}\n", txtNum1.Text, aux, this.txtNum2.Text, this.lblResultado.Text);
            this.lstOperaciones.Items.Add(sb.ToString());
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            lblResultado.Text = op1.BinarioDecimal(txtNum1.Text);
            sb.AppendFormat("{0}={1}\n", txtNum1.Text, lblResultado.Text);
            this.lstOperaciones.Items.Add(sb.ToString());
        }

        private void Limpiar()
        {
            txtNum1.Text = "0";
            txtNum2.Text = "0";
            lblResultado.Text = "0";
            cboOperator.Text = " ";
            lstOperaciones.Items.Clear();
        }

    }
}
