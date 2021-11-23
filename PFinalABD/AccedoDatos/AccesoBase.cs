using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace AccedoDatos
{
    public class AccesoBase
    {
        MySqlConnection _conn;
        public AccesoBase(string server, string user, string password, string based, uint port)
        {
            _conn = new MySqlConnection(string.Format("server={0}; user={1}; password={2}; database={3};" +
                "port={4}", server, user, password, based, port));
        }
        public void Consultar(string consulta)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(consulta, _conn);
                _conn.Open();
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (Exception)
            {

            }
        }
        public string ConsultaRetorno(string consulta)
        {
            string r;
            try
            {
                _conn.Open();

                var command = new MySqlCommand(consulta, _conn);
                command.ExecuteNonQuery();
                r = Convert.ToString(command.ExecuteScalar());

                _conn.Close();
                return r;
            }
            catch (Exception)
            {

                return "ERROR";
            }
        }

        public DataSet Mostrar(string tabla, string consulta)
        {
            var ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, _conn);
                _conn.Open();
                da.Fill(ds, tabla);
                _conn.Close();
                return ds;
            }
            catch (Exception)
            {
                _conn.Close();
                return ds;
            }
        }
        public DataSet ObtenerDatos(string consulta, string tabla)
        {
            var ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, _conn);
            da.Fill(ds, tabla);

            return ds;
        }
    }
}
