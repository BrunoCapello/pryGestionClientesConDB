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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        clsCiudad objCiudad = new clsCiudad();
        clsClientes objClientes = new clsClientes();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objClientes.Nombre = txtNombre.Text;
            objClientes.Limite = Convert.ToDecimal(txtLimite.Text);
            objClientes.idCiudad = Convert.ToInt32(cboCiudad.SelectedValue);
            objClientes.Agregar();

            txtLimite.Clear();
            txtNombre.Clear();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            objCiudad.Listar(cboCiudad);
        }
    }
}
