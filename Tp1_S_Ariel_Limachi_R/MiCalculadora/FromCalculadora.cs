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
        public FromCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes){
                this.Dispose();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Operando op1 = new Operando();
            this.txtResultado.Text= op1.DecimalBinario(this.txtNum1.Text);
            sb.AppendFormat("{0} -> {1}\n",  txtNum1.Text, this.txtResultado.Text);
            this.lstOperaciones.Items.Add(sb.ToString());
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Operando op1 = new Operando(this.txtNum1.Text);
            Operando op2 = new Operando(this.txtNum2.Text);
            this.txtResultado.Text = Calculadora.Operar(op1, op2, this.cboOperator.Text[0]).ToString();
            sb.AppendFormat("{0} {1} {2} = {3}\n", txtNum1.Text, this.cboOperator.Text, this.txtNum2.Text, this.txtResultado.Text);
            this.lstOperaciones.Items.Add(sb.ToString());
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Operando op1 = new Operando();
            this.txtResultado.Text = op1.BinarioDecimal(txtNum1.Text);
            sb.AppendFormat("{0} -> {1}\n", txtNum1.Text, this.txtResultado.Text);
            this.lstOperaciones.Items.Add(sb.ToString());
        }

        private void Limpiar()
        {
            txtNum1.Text = "0";
            txtNum2.Text = "0";
            this.txtResultado.Text = "0";
            cboOperator.Text = " ";
            lstOperaciones.Items.Clear();
        }

        private void FromCalculadora_Load(object sender, EventArgs e)
        {

        }
        private void CerrarFormulario(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }        
        }
    }
}
