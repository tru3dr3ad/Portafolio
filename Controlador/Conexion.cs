using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Conexion
    {
        public Conexion()
        {

        }
        public OracleDataReader EjecutarQuery(string sqlString)
        {
            OracleConnection conexion = ConexionBd();
            conexion.Open();

            OracleCommand command = conexion.CreateCommand();
            command.CommandText = sqlString;
            OracleDataReader reader = command.ExecuteReader();
            reader.Close();
            command.Dispose();
            conexion.Close();
            return reader;
        }
        public OracleConnection ConexionBd()
        {

            OracleConnection connection = new OracleConnection();
            if (OracleConnection.IsAvailable == true)
            {
                connection.ConnectionString = "context connection=true";
            }
            else
            {
                //set connection string for a normal client connection
                connection.ConnectionString = "user id=ALMACEN;password=123;" +
                  "data source=localhost:1521/xepdb1";
                return connection;
            }
            return connection;
        }
    }
}
