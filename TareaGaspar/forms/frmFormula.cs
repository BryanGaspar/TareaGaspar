using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaGaspar.forms
{
    public partial class frmFormula : Form
    {
        public frmFormula()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtInicio.Text);
            int n = Convert.ToInt32(txtFin.Text);
            double res = Evaluar.Expresion.calcularExpresion(i, n);
            txtRes.Text = res.ToString();
        }
    }
}
