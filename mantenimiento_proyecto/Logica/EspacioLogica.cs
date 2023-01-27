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

            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar datos \n\n\n" + ex);
            }
            return respuesta;
        }

        public List<Espacio> Listar(int idArea1)
        {
            List<Espacio> lista = new List<Espacio>();

            try
            {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer datos \n\n\n"+ex);
            }
            return lista;
        }

        public bool Editar(Espacio obj)
        {
            bool respuesta = true;

            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar datos \n\n\n"+ex);
            }
            return respuesta;
        }

        public bool Eliminar(Espacio obj)
        {
            bool respuesta = true;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();

                    //Eliminar un espacio implica borrar sus hallazgos tambien
                    string query = "delete from Espacio where idEspacio=@idEspacio";
                    string query2 = "delete from Hallazgo2 where idEspacio=@idEspacio";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    SQLiteCommand cmd2 = new SQLiteCommand(query2, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@idEspacio", obj.idEspacio));
                    cmd2.Parameters.Add(new SQLiteParameter("@idEspacio", obj.idEspacio));
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd2.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1 || cmd2.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos \n\n\n"+ex);
            }
            return respuesta;
        }

        public int buscarEspacio(String nombreE)
        {
            int idEncontrado = 0;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "select idEspacio from Espacio where nombre = @nombreEspacio;";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@nombreEspacio", nombreE));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            idEncontrado = Convert.ToInt32(dr["idEspacio"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer datos \n\n\n" + ex);
            }
            return idEncontrado;
        }

        public bool EliminarDesdeArea(int idArea)
        {
            bool respuesta = true;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();

                    //Eliminar un espacio implica borrar sus hallazgos tambien
                    string query = "delete from Espacio where idArea=@idArea";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@idArea", idArea));
                    cmd.CommandType = System.Data.CommandType.Text;


                    if (cmd.ExecuteNonQuery() < 1 )
                    {
                        respuesta = false;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos \n\n\n" + ex);
            }
            return respuesta;
        }

    }
}
