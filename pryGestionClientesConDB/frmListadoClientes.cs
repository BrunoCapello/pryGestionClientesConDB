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

            if (objArchivo.ShowDialog() == DialogResult.OK)
            {
                objClientes.ReporteClientesCuadroDialogo(objArchivo.FileName);
                MessageBox.Show("Reporte generado correctamente");
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objClientes.ListarDataSet(dgvDataSet);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (prtVentana.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
                    prtDocumento.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo imprimir: " + ex.Message);
                }
            }
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Font TipoLetra = new Font("Sans Serif", 12, FontStyle.Bold);
            //e.Graphics.DrawString("Hola Mundo", TipoLetra, Brushes.Blue, 200, 200);

            objClientes.Imprimir(e);
        }
    }
}
