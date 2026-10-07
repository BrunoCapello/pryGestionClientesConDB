using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionClientesConDB
{
    public partial class frmDeudores : Form
    {
        public frmDeudores()
        {
            InitializeComponent();
        }

        clsClientes objCliente = new clsClientes();

        private void btnListar_Click(object sender, EventArgs e)
        {
            objCliente.Deudores(dgvListado);
            lblMuestraCantClientes.Text = objCliente.Cantidad.ToString();
            lblMuestraTotalDeuda.Text = objCliente.Total.ToString();
            lblMuestraPromDeuda.Text = objCliente.PromedioDeuda.ToString("0.00");
        }
    }
}
