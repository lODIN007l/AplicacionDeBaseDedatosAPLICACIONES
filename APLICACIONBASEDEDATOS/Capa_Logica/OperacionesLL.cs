using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_BD;

namespace Capa_Logica
{
    class OperacionesLL
    {
        private OperacionesBD objOperaciones = new OperacionesBD();

        public DataTable MostrarUsuarios()
        {
            DataTable tabla = objOperaciones.MostrarUsuarios();
            return tabla;
            
        }

        public DataTable MostrarCursos()
        {
            DataTable tabla = objOperaciones.MostrarCursos();
            return tabla;
        }

        public DataTable MostrarVideos(int cod_curso)
        {
            DataTable tabla = objOperaciones.MostrarVideos(cod_curso);
            return tabla;
        }

        public DataTable MostrarComprados(int cod_curso)
        {
            DataTable tabla = objOperaciones.MostrarVideos(cod_curso);
            return tabla;
        }

        public DataTable BuscarUsuario(string nomb)
        {
            DataTable tabla = objOperaciones.BuscarUsuario(nomb);
            return tabla;

        }

        public DataTable BuscarCurso(int cod)
        {
            DataTable tabla = objOperaciones.MostrarVideos(cod);
            return tabla;
        }

        public void IngresarUsuario(string nombre, string correo, string password)
        {
            objOperaciones.IngresarUsuario(nombre, correo, password);
        }

        public void IngresarCurso(string titulo, string lenguaje, string descripcion, string precio)
        {
            objOperaciones.IngresarCurso(titulo, lenguaje, descripcion, precio);
        }

        public void IngresarVideo(string titulo, string duracion)
        {
            objOperaciones.IngresarVideo(titulo, duracion);
        }
        public void CursoComprado(int cod_usu, int cod_video)
        {
            objOperaciones.CursoComprado(cod_usu, cod_video);
        }

        public void EliminarUsuario(int cod)
        {
            objOperaciones.EliminarUsuario(cod);
        }

        public void EliminarCurso(int cod)
        {
            objOperaciones.EliminarCurso(cod);
        }

        public void EliminarVideo(int cod_curso, int cod_video)
        {
            objOperaciones.EliminarVideo(cod_curso, cod_video);
        }

        public void EditarUsuario(int cod,string correo, string password)
        {
            objOperaciones.EditarUsuario(cod,correo, password);
        }

        public void EditarCurso(int codigo, string titulo, string lenguaje, string descripcion, string precio)
        {
            objOperaciones.EditarCurso(codigo, titulo, lenguaje, descripcion, precio);
        }

        public void EditarVideo(int cod_curso, int cod_video, string titulo, string duracion)
        {
            objOperaciones.EditarVideo(cod_curso, cod_video, titulo, duracion);
        }
    }
}
