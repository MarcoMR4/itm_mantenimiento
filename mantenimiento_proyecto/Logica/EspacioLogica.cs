using mantenimiento_proyecto.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantenimiento_proyecto.Logica
{
    internal class EspacioLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static EspacioLogica _instancia = null;

        public EspacioLogica() { }

        public static EspacioLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new EspacioLogica();
                }
                return _instancia;
            }
        }

        public bool Guardar(Espacio obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into Espacio(nombre,idArea) values (@nombre,@idArea)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.nombre));
                cmd.Parameters.Add(new SQLiteParameter("@idArea", obj.idArea));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

        public List<Espacio> Listar(int idArea1)
        {
            List<Espacio> lista = new List<Espacio>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Espacio where idArea=@idArea";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@idArea", idArea1));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Espacio()
                        {
                            idEspacio = int.Parse(dr["idEspacio"].ToString()),
                            nombre = dr["nombre"].ToString(),
                            idArea = int.Parse(dr["idArea"].ToString())
                        });
                    }
                }

                return lista;
            }
        }

        public bool Editar(Espacio obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "update Espacio set nombre=@nombre where idEspacio=@idEspacio";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.nombre));
                cmd.Parameters.Add(new SQLiteParameter("@idEspacio", obj.idEspacio));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

        public bool Eliminar(Espacio obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "delete from Espacio where idEspacio=@idEspacio";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@idEspacio", obj.idEspacio));
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
