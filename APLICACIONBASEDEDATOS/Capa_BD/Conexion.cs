using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Capa_BD
{
    public class Conexion
    {
        public SqlConnection conectar;
        public Conexion()
        {
            conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["APLICACIONBASEDEDATOS.Properties.Settings.Conexion"].ConnectionString);
        }

        public void Abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch(Exception exc)
            {
                Console.WriteLine("Error al abiri la conexion", exc.Message);
            }
        }

        public void Cerrar()
        {
            conectar.Close();
        }
    }
}
