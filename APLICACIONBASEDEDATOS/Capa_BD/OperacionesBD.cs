using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Capa_BD
{
    public class OperacionesBD
    {
        Conexion objConectar = new Conexion();

        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            try
            {
                objConectar.Abrir();
                SqlCommand comando = new SqlCommand("comando", objConectar.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception exc)
            {
                objConectar.Cerrar();
                tabla = null;
            }
            return tabla;
        }

        public DataTable MostrarCursos()
        {
            DataTable tabla = new DataTable();
            try
            {
                objConectar.Abrir();
                SqlCommand comando = new SqlCommand("comando", objConectar.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception exc)
            {
                objConectar.Cerrar();
                tabla = null;
            }
            return tabla;
        }

        public DataTable MostrarVideos(int cod_curso)
        {
            DataTable tabla = new DataTable();
            try
            {
                objConectar.Abrir();
                SqlCommand comando = new SqlCommand("comando", objConectar.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception exc)
            {
                objConectar.Cerrar();
                tabla = null;
            }
            return tabla;
        }

        public DataTable MostrarComprados(int cod_curso)
        {
            DataTable tabla = new DataTable();
            try
            {
                objConectar.Abrir();
                SqlCommand comando = new SqlCommand("comando", objConectar.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception exc)
            {
                objConectar.Cerrar();
                tabla = null;
            }
            return tabla;
        }

        public DataTable BuscarUsuario(string nomb)
        {
            DataTable tabla = new DataTable();
            try
            {
                objConectar.Abrir();
                SqlCommand comando = new SqlCommand("comando", objConectar.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch(Exception exc)
            {
                objConectar.Cerrar();
                tabla = null;
            }
            return tabla;

        }

        public DataTable BuscarCurso(int cod)
        {
            DataTable tabla = new DataTable();
            try
            {
                objConectar.Abrir();
                SqlCommand comando = new SqlCommand("comando", objConectar.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception exc)
            {
                objConectar.Cerrar();
                tabla = null;
            }
            return tabla;
        }

        public void IngresarUsuario(string nombre, string correo, string password)
        {
            objConectar.Abrir();
            string cmInsertar = "comando";
            SqlCommand comando = new SqlCommand(cmInsertar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void IngresarCurso(string titulo, string lenguaje, string descripcion, string precio)
        {
            objConectar.Abrir();
            string cmInsertar = "comando";
            SqlCommand comando = new SqlCommand(cmInsertar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void IngresarVideo(string titulo, string duracion)
        {
            objConectar.Abrir();
            string cmInsertar = "comando";
            SqlCommand comando = new SqlCommand(cmInsertar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }
        public void CursoComprado(int cod_usu, int cod_video)
        {
            objConectar.Abrir();
            string cmInsertar = "comando";
            SqlCommand comando = new SqlCommand(cmInsertar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }
        
        public void EliminarUsuario(int cod)
        {
            objConectar.Abrir();
            string cmInsertar = "comando";
            SqlCommand comando = new SqlCommand(cmInsertar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void EliminarCurso(int cod)
        {
            objConectar.Abrir();
            string cmEliminar = "comando";
            SqlCommand comando = new SqlCommand(cmEliminar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void EliminarVideo(int cod_curso, int cod_video)
        {
            objConectar.Abrir();
            string cmEliminar = "comando";
            SqlCommand comando = new SqlCommand(cmEliminar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void EditarUsuario(int cod,string correo, string password) 
        {
            objConectar.Abrir();
            string cmEditar = "comando";
            SqlCommand comando = new SqlCommand(cmEditar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void EditarCurso(int codigo, string titulo, string lenguaje, string descripcion, string precio)
        {
            objConectar.Abrir();
            string cmEditar = "comando";
            SqlCommand comando = new SqlCommand(cmEditar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void EditarVideo(int cod_curso,int cod_video, string titulo, string duracion)
        {
            objConectar.Abrir();
            string cmEditar = "comando";
            SqlCommand comando = new SqlCommand(cmEditar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

    }
}
