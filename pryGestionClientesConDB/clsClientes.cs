using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;

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


        private string CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=..\\..\\Clientes.mdb";
        private string Tabla = "Lista";

        private Decimal deuda;
        private Int32 cantidad;

        private Int32 IdCLiente;
        private string nombre;
        private decimal deudaCliente;
        private decimal limite;
        private Int32 IdCiudad;

        //Propiedades
        public Decimal Total
        {
            get { return deuda; }
        }
        public Int32 Cantidad
        {
            get { return cantidad; }
        }
        public Decimal PromedioDeuda
        {
            get { return deuda / cantidad; }
        }

        public Int32 idCliente
        {
            get { return IdCLiente; }
            set { IdCLiente = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Decimal Deuda
        {
            get { return deudaCliente; }
            set { deudaCliente = value; }
        }
        public Decimal Limite
        {
            get { return limite; }
            set { limite = value; }
        }
        public Int32 idCiudad
        {
            get { return IdCiudad; }
            set { IdCiudad = value; }
        }

        public void Listar(DataGridView dgv)
        {
            try
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
                dgv.DataSource = ds.Tables[0];

                conexion.Close();
            } 
            catch (Exception e)
            {
                MessageBox.Show("Error al listar los datos " + e.ToString());
            }
            
        }

        public void Deudores(DataGridView dgv)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();    

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                //Ejecutamos el comando
                OleDbDataReader DataReader = comando.ExecuteReader();
                dgv.Rows.Clear();

                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        if (DataReader.GetDecimal(2) > 0)
                        {
                            dgv.Rows.Add(
                                DataReader.GetInt32(0),
                                DataReader.GetString(1),
                                DataReader.GetDecimal(2)
                            );
                            cantidad++;
                            deuda += DataReader.GetDecimal(2);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al listar los datos " + e.ToString());
            }

            dgv.ClearSelection();
        }

    public void BuscarDeudores(Int32 Cliente)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DataReader = comando.ExecuteReader();

                idCliente = 0;
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        if (DataReader.GetInt32(0) == Cliente)
                        {
                            IdCLiente = DataReader.GetInt32(0);
                            nombre = DataReader.GetString(1);
                            deudaCliente = DataReader.GetDecimal(2);
                            limite = DataReader.GetDecimal(3);
                            IdCiudad = DataReader.GetInt32(4);
                        }
                    }
                }
                
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al listar los datos " + e.ToString());
            }

        }
    }
}
