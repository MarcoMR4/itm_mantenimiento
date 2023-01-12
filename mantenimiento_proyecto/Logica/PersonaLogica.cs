using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using mantenimiento_proyecto.Models;

namespace mantenimiento_proyecto.Logica
{
    internal class PersonaLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static PersonaLogica _instancia = null;

        public PersonaLogica() { }

        public static PersonaLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PersonaLogica();
                }
                return _instancia;
            }
        }

        public bool Guardar(Personal obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into Personal(nombres,apellidoPaterno,apellidoMaterno,cargo,idArea) values (@nombres,@apellidoPaterno,@apellidoMaterno,@cargo,@idArea)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombres", obj.nombres));
                cmd.Parameters.Add(new SQLiteParameter("@apellidoPaterno", obj.apellidoPaterno));
                cmd.Parameters.Add(new SQLiteParameter("@apellidoMaterno", obj.apellidoMaterno));
                cmd.Parameters.Add(new SQLiteParameter("@cargo", obj.cargo));
                cmd.Parameters.Add(new SQLiteParameter("@idArea", obj.idArea));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

        public List<Personal> Listar()
        {
            List<Personal> lista = new List<Personal>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Personal p inner join Area a on p.idArea=a.idArea";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Personal()
                        {
                            idPersonal = int.Parse(dr["idPersonal"].ToString()),
                            nombres = dr["nombres"].ToString(),
                            apellidoMaterno = dr["apellidoMaterno"].ToString(),
                            cargo = dr["cargo"].ToString(),
                            idArea = int.Parse(dr["idArea"].ToString()),
                            nombreArea = dr["nombre"].ToString(),
                            apellidoPaterno = dr["apellidoPaterno"].ToString()
                        }
                        ) ;
                        
                    }
                }

                return lista;
            }
        }

        public bool Editar(Personal obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "update Personal set nombres=@nombres,apellidoPaterno=@apellidoPaterno,apellidoMaterno=@apellidoMaterno,cargo=@cargo,idArea=@idArea where idPersonal=@idPersonal";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@idPersonal", obj.idPersonal));
                cmd.Parameters.Add(new SQLiteParameter("@nombres", obj.nombres));
                cmd.Parameters.Add(new SQLiteParameter("@apellidoPaterno", obj.apellidoPaterno));
                cmd.Parameters.Add(new SQLiteParameter("@apellidoMaterno", obj.apellidoMaterno));
                cmd.Parameters.Add(new SQLiteParameter("@cargo", obj.cargo));
                cmd.Parameters.Add(new SQLiteParameter("@idArea", obj.idArea));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Eliminar(Personal obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "delete from Personal where idPersonal=@idPersonal";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@idPersonal", obj.idPersonal));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

    }
}
