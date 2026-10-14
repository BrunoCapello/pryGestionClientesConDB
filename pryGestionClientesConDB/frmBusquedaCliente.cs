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
    public partial class frmBusquedaCliente : Form
    {
        public frmBusquedaCliente()
        {
            InitializeComponent();
        }

        clsClientes objClientes = new clsClientes();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objClientes.BuscarDeudores(Convert.ToInt32(txtCodigo.Text));

            if (objClientes.idCliente == 0)
            {
                MessageBox.Show("El cliente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                lblMostrarDeuda.Text = objClientes.Deuda.ToString();
                lblMostrarLimite.Text = objClientes.Limite.ToString();
                lblMostrarNombre.Text = objClientes.Nombre;
            }

            txtCodigo.Clear();
            txtCodigo.Focus();
        }
    }
}
