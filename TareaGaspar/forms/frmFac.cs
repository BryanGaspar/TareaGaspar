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
    public partial class frmFac : Form
    {
        public frmFac()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            long res = Tarea.Utilidades.sumfactorial(num);
            lbRes.Text = res.ToString();
            lbRes.Visible = true;
        }
    }
}
