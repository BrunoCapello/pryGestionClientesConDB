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
    internal class clsClientes
    {
        //Conexion a la base de datos
        private OleDbConnection conexion = new OleDbConnection();

        //Comando para ejecutar la consulta
        private OleDbCommand comando = new OleDbCommand();

        //Adapta los datos de I/O con la db
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        private string CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Alumno\\source\\repos\\pryGestionClientesConDB\\pryGestionClientesConDBClientes.mdb";
        private string Tabla = "Lista";

        public void Listar(DataGridView dgv)
        {
            //ConectionString solo sirve para conectar la Cadena de conexion a la base de datos, no para ejecutar consultas
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();

            //Ejecutamos la conexión, le decimos que tipo de tabla usamos y cual usamos
            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = Tabla;

            //Adaptamos los datos de toda la tabla y los cargamos a ds(DataSet)
            adaptador = new OleDbDataAdapter(comando);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);

            //Mostramos los datos en el DataGridView
            dgv.Rows.Clear();
            dgv.DataSource = ds.Tables[0];

            conexion.Close();
        }
    }
}
