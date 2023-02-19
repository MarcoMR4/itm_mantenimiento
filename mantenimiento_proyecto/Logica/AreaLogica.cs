using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using mantenimiento_proyecto.Models;
using System.Data.SQLite;

namespace mantenimiento_proyecto.Logica
{
    public class AreaLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static AreaLogica _instancia = null;

        public AreaLogica() { }

        public static AreaLogica Instancia
        {
            get 
            {
                if (_instancia == null)
                {
                    _instancia = new AreaLogica();
                }
                return _instancia; 
            } 
        }


        public bool Guardar(Area obj)
        {
            bool respuesta = true;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "insert into Area(nombreArea) values (@nombre)";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.nombre));
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar datos \n\n\n"+ex);
            }

            return respuesta;
        }

        public List<Area> Listar() 
        {       
            List<Area> lista = new List<Area>();

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "select * from Area";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Area()
                            {
                                idArea = int.Parse(dr["idArea"].ToString()),
                                nombre = dr["nombreArea"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer datos \n\n\n" + ex);
            }
            return lista;
        }

        public bool Editar(Area obj)
        {
            bool respuesta = true;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "update Area set nombreArea=@nombreArea where idArea=@idarea";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@nombreArea", obj.nombre));
                    cmd.Parameters.Add(new SQLiteParameter("@idarea", obj.idArea));
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

        public bool Eliminar(Area obj)
        {
            bool respuesta = true;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    //Eliminar 1 area implica tambien a sus servicios y Personal, espacios y hallazgos
                    conexion.Open();
                    string query = "delete from Area where idArea=@idarea";
                    string query2 = "delete from Personal where idArea=@idarea";
                    string query3 = "delete from Servicio2 where idArea=@idarea";
                 

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    SQLiteCommand cmd2 = new SQLiteCommand(query2, conexion);
                    SQLiteCommand cmd3 = new SQLiteCommand(query3, conexion);
                    

                    cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.nombre));
                    cmd.Parameters.Add(new SQLiteParameter("@idarea", obj.idArea));
                    cmd2.Parameters.Add(new SQLiteParameter("@idarea", obj.idArea));
                    cmd3.Parameters.Add(new SQLiteParameter("@idarea", obj.idArea));
                   

                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd2.CommandType = System.Data.CommandType.Text;
                    cmd3.CommandType = System.Data.CommandType.Text;
                 


                    if (cmd.ExecuteNonQuery() < 1 || cmd2.ExecuteNonQuery() < 1 || cmd3.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
                EspacioLogica.Instancia.EliminarDesdeArea(obj.idArea);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar datos \n\n\n"+ex);    
                //throw;
            }

            return respuesta;
        }

        public int buscarArea(String nombreA)
        {
            int idEncontrado = 0;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "select idArea from Area where nombreArea = @nombreArea;";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@nombreArea", nombreA));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            idEncontrado = Convert.ToInt32(dr["idArea"]);
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

        public List<Area> Filtrar(int idA)
        {
            List<Area> lista = new List<Area>();

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "select * from Area where idArea=@idA";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@idA", idA));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Area()
                            {
                                idArea = int.Parse(dr["idArea"].ToString()),
                                nombre = dr["nombreArea"].ToString()
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

    }
}
