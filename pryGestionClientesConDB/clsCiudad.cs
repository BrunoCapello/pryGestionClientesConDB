using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;



namespace pryGestionClientesConDB
{
    internal class clsCiudad
    {
        private OleDbConnection conexion = new OleDbConnection();

        //Comando para ejecutar la consulta
        private OleDbCommand comando = new OleDbCommand();

        //Adapta los datos de I/O con la db
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        private string CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=..\\..\\Clientes.mdb";
        private string Tabla = "Ciudad";

        public void Listar(DataGridView dgv)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                //Adapta los datos a la base de datos
                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);

                //Mostramos los datos en el DataGridView
                dgv.DataSource = ds.Tables[0];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }

        public void Listar(ComboBox cbo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                cbo.DataSource = DS.Tables[Tabla];
                cbo.DisplayMember = "Nombre";
                cbo.ValueMember = "idCiudad";

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }
    }
}
