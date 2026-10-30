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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        clsClientes objClientes = new clsClientes();

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsClientes objClientes = new clsClientes();
            objClientes.Listar(dgvListado);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();

            objArchivo.Title = "Seleccione la carpeta y escriba el nombre del archvo";
            objArchivo.RestoreDirectory = true;
            objArchivo.Filter = "Archivos separados por coma (*.csv)|*.csv|Archivos de texto (*.txt)|*.txt";

            objArchivo.ShowDialog();


            objClientes.ReporteClientesCuadroDialogo(objArchivo.FileName);
            MessageBox.Show("Reporte generado correctamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objClientes.ListarDataSet(dgvDataSet);
        }
    }
}
