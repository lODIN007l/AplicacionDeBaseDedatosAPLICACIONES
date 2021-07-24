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
                SqlCommand comando = new SqlCommand("SELECT * FROM usuarios", objConectar.conectar);
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
                SqlCommand comando = new SqlCommand("SELECT * FROM cursos", objConectar.conectar);
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

        public DataTable MostrarVideos(int codigo)
        {
            DataTable tabla = new DataTable();
            try
            {
                string cmd = "select cod_video,titulo,duracion from videos where cod_curso = "+codigo;
                objConectar.Abrir();
                SqlCommand comando = new SqlCommand(cmd, objConectar.conectar);
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

        public DataTable MostrarComprados(int codigo)
        {
            DataTable tabla = new DataTable();
            try
            {
                string cmd = "Select nombre,fecha from compras inner join usuarios on usuarios.cod_usuario = compras.cod_usuario where compras.cod_usuario = " + codigo;
                objConectar.Abrir();
                SqlCommand comando = new SqlCommand(cmd, objConectar.conectar);
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

        public DataTable BuscarUsuario(int cod)
        {
            DataTable tabla = new DataTable();
            try
            {
                string cmd = "select * from usuarios where cod_usuarios=" + cod; 
                objConectar.Abrir();
                SqlCommand comando = new SqlCommand(cmd, objConectar.conectar);
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
                string cmd = "Select * from cursos where cod_curso=" + cod;
                objConectar.Abrir();
                SqlCommand comando = new SqlCommand(cmd, objConectar.conectar);
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
            string cmInsertar = "insert into usuarios(nombre,correo,password) VALUES('" + nombre + "','" + correo + "','" + password + "')";
            SqlCommand comando = new SqlCommand(cmInsertar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void IngresarCurso(string titulo, string lenguaje, string descripcion, float precio)
        {
            //transformacion de string a float desde la capalogica
            objConectar.Abrir();
            string cmInsertar = "insert into cursos(titulo,lenguaje,descripcion,precio) VALUES('" + titulo + "','" + lenguaje + "','" + descripcion + "'," + precio + ")";
            SqlCommand comando = new SqlCommand(cmInsertar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void IngresarVideo(int curso,string titulo, string duracion)
        {
            objConectar.Abrir();
            string cmInsertar = "insert into videos(cod_curso,nombre, correo, password) VALUES("+ curso +"'" + titulo + "'," + duracion +")";
            SqlCommand comando = new SqlCommand(cmInsertar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }
        public void CursoComprado(int usuario, int curso)
        {
            objConectar.Abrir();
            string f = DateTime.Now.ToString("yyyy-mm-dd");
            string cmInsertar = "insert into compras(cod_curso,cod_usuario,fecha) values('"+curso+"','"+usuario+"','"+f+"')";
            SqlCommand comando = new SqlCommand(cmInsertar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }
        
        public void EliminarUsuario(int cod)
        {
            objConectar.Abrir();
            string cmInsertar = "delete from usuarios where cod_usuario ="+cod;
            SqlCommand comando = new SqlCommand(cmInsertar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void EliminarCurso(int cod)
        {
            objConectar.Abrir();
            string cmEliminar = "delete from cursos where cod_curso="+cod;
            SqlCommand comando = new SqlCommand(cmEliminar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void EliminarVideo(int cod)
        {
            objConectar.Abrir();
            string cmEliminar = "delete from videos where cod_video="+cod;
            SqlCommand comando = new SqlCommand(cmEliminar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void EditarUsuario(int cod,string nombre,string correo, string password) 
        {
            objConectar.Abrir();
            string cmEditar = "UPDATE usuarios SET correo='" + correo + "',password= '" + password + "' where cod_usuario='" + cod + "'";
            SqlCommand comando = new SqlCommand(cmEditar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void EditarCurso(int codigo, string titulo, string lenguaje, string descripcion, float precio)
        {
            objConectar.Abrir();
            string cmEditar = "UPDATE cursos SET titulo='" + titulo + "',lenguaje= '" + lenguaje + "',descripcion='" + descripcion + "',precio='" + precio + "' where cod_curso=" + codigo;
            SqlCommand comando = new SqlCommand(cmEditar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

        public void EditarVideo(int cod_video, string titulo, string duracion)
        {
            objConectar.Abrir();
            string cmEditar = "UPDATE videos SET titulo= '" + titulo + "',duracion='" + duracion + "' where cod_video=" + cod_video;
            SqlCommand comando = new SqlCommand(cmEditar, objConectar.conectar);
            comando.ExecuteNonQuery();
            objConectar.Cerrar();
        }

    }
}
