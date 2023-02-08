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
    internal class ServicioLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ServicioLogica _instancia = null;

        public ServicioLogica() { }

        public static ServicioLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ServicioLogica();
                }
                return _instancia;
            }
        }

        //Create
        public bool Guardar(Servicio obj)
        {
            bool respuesta = true;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "insert into Servicio2(descripcion,tipo,periodo,anio,idArea,enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre) " +
                        "values (@descripcion,@tipo,@periodo,@anio,@idArea,@enero,@febrero,@marzo,@abril,@mayo,@junio,@julio,@agosto,@septiembre,@octubre,@noviembre,@diciembre)";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@descripcion", obj.descripcion));
                    cmd.Parameters.Add(new SQLiteParameter("@tipo", obj.tipoServicio));
                    cmd.Parameters.Add(new SQLiteParameter("@periodo", obj.periodo));
                    cmd.Parameters.Add(new SQLiteParameter("@anio", obj.anio));
                    cmd.Parameters.Add(new SQLiteParameter("@idArea", obj.idArea));
                    cmd.Parameters.Add(new SQLiteParameter("@enero", obj.enero));
                    cmd.Parameters.Add(new SQLiteParameter("@febrero", obj.febrero));
                    cmd.Parameters.Add(new SQLiteParameter("@marzo", obj.marzo));
                    cmd.Parameters.Add(new SQLiteParameter("@abril", obj.abril));
                    cmd.Parameters.Add(new SQLiteParameter("@mayo", obj.mayo));
                    cmd.Parameters.Add(new SQLiteParameter("@junio", obj.junio));
                    cmd.Parameters.Add(new SQLiteParameter("@julio", obj.julio));
                    cmd.Parameters.Add(new SQLiteParameter("@agosto", obj.agosto));
                    cmd.Parameters.Add(new SQLiteParameter("@septiembre", obj.septiembre));
                    cmd.Parameters.Add(new SQLiteParameter("@octubre", obj.octubre));
                    cmd.Parameters.Add(new SQLiteParameter("@noviembre", obj.noviembre));
                    cmd.Parameters.Add(new SQLiteParameter("@diciembre", obj.diciembre));

                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar los datos \n\n\n"+ex);
            }
          
            return respuesta;
        }

        //Read 
        public List<Servicio> Listar1(int idArea1, int anio1)
        {
            List<Servicio> lista = new List<Servicio>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Servicio2 where idArea=@idArea and periodo='enero-junio' " +
                    "and anio=@anio";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@idArea", idArea1));
                cmd.Parameters.Add(new SQLiteParameter("@anio", anio1));

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Servicio()
                        {
                            idServicio = int.Parse(dr["idServicio"].ToString()),
                            descripcion = dr["descripcion"].ToString(),
                            tipoServicio = dr["tipo"].ToString(),
                            periodo = dr["periodo"].ToString(),
                            anio = int.Parse(dr["anio"].ToString()),
                            idArea = int.Parse(dr["idArea"].ToString()),
                            enero = int.Parse(dr["enero"].ToString()),
                            febrero = int.Parse(dr["febrero"].ToString()),
                            marzo = int.Parse(dr["marzo"].ToString()),
                            abril = int.Parse(dr["abril"].ToString()),
                            mayo = int.Parse(dr["mayo"].ToString()),
                            junio = int.Parse(dr["junio"].ToString()),
                            
                        });
                    }
                }

                return lista;
            }
        }

        public List<Servicio> Listar2(int idArea1, int anio1)
        {
            List<Servicio> lista = new List<Servicio>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Servicio2 where idArea=@idArea and periodo='agosto-diciembre' " +
                    "and anio=@anio";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@idArea", idArea1));
                cmd.Parameters.Add(new SQLiteParameter("@anio", anio1));

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Servicio()
                        {
                            idServicio = int.Parse(dr["idServicio"].ToString()),
                            descripcion = dr["descripcion"].ToString(),
                            tipoServicio = dr["tipo"].ToString(),
                            periodo = dr["periodo"].ToString(),
                            anio = int.Parse(dr["anio"].ToString()),
                            idArea = int.Parse(dr["idArea"].ToString()),
                            julio = int.Parse(dr["julio"].ToString()),
                            agosto = int.Parse(dr["agosto"].ToString()),
                            septiembre = int.Parse(dr["septiembre"].ToString()),
                            octubre = int.Parse(dr["octubre"].ToString()),
                            noviembre = int.Parse(dr["noviembre"].ToString()),
                            diciembre = int.Parse(dr["diciembre"].ToString()),
                        });
                    }
                }

                return lista;
            }
        }

        //Create
        public bool Editar(Servicio obj)
        {
            bool respuesta = true;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "update Servicio2 set descripcion=@descripcion," +
                        "tipo=@tipo," +
                        "enero=@enero," +
                        "febrero=@febrero," +
                        "marzo=@marzo," +
                        "abril=@abril," +
                        "mayo=@mayo," +
                        "junio=@junio," +
                        "julio=@julio," +
                        "agosto=@agosto," +
                        "septiembre=@septiembre," +
                        "octubre=@octubre," +
                        "noviembre=@noviembre," +
                        "diciembre=@diciembre" +
                        " where idServicio=@idServicio";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@idServicio", obj.idServicio));
                    cmd.Parameters.Add(new SQLiteParameter("@descripcion", obj.descripcion));
                    cmd.Parameters.Add(new SQLiteParameter("@tipo", obj.tipoServicio));
                    cmd.Parameters.Add(new SQLiteParameter("@enero", obj.enero));
                    cmd.Parameters.Add(new SQLiteParameter("@febrero", obj.febrero));
                    cmd.Parameters.Add(new SQLiteParameter("@marzo", obj.marzo));
                    cmd.Parameters.Add(new SQLiteParameter("@abril", obj.abril));
                    cmd.Parameters.Add(new SQLiteParameter("@mayo", obj.mayo));
                    cmd.Parameters.Add(new SQLiteParameter("@junio", obj.junio));
                    cmd.Parameters.Add(new SQLiteParameter("@julio", obj.julio));
                    cmd.Parameters.Add(new SQLiteParameter("@agosto", obj.agosto));
                    cmd.Parameters.Add(new SQLiteParameter("@septiembre", obj.septiembre));
                    cmd.Parameters.Add(new SQLiteParameter("@octubre", obj.octubre));
                    cmd.Parameters.Add(new SQLiteParameter("@noviembre", obj.noviembre));
                    cmd.Parameters.Add(new SQLiteParameter("@diciembre", obj.diciembre));

                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar editar los datos \n\n\n" + ex);
            }

            return respuesta;
        }

        //Delete
        public bool Eliminar(Servicio obj)
        {
            bool respuesta = true;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "delete from Servicio2 " +
                        "where idServicio=@idServicio";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@idServicio", obj.idServicio));
                    

                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar los datos \n\n\n" + ex);
            }

            return respuesta;
        }


        //Lista total 
        public List<Servicio> ListarTodos1(int anio)
        {
            List<Servicio> lista = new List<Servicio>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "select * from Servicio2 where periodo='enero-junio' and anio=@anio " +
                    "order by enero desc, febrero desc, marzo desc, abril desc, mayo desc, junio desc";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@anio", anio));

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Servicio()
                        {
                            idServicio = int.Parse(dr["idServicio"].ToString()),
                            descripcion = dr["descripcion"].ToString(),
                            tipoServicio = dr["tipo"].ToString(),
                            periodo = dr["periodo"].ToString(),
                            anio = int.Parse(dr["anio"].ToString()),
                            idArea = int.Parse(dr["idArea"].ToString()),
                            enero = int.Parse(dr["enero"].ToString()),
                            febrero = int.Parse(dr["febrero"].ToString()),
                            marzo = int.Parse(dr["marzo"].ToString()),
                            abril = int.Parse(dr["abril"].ToString()),
                            mayo = int.Parse(dr["mayo"].ToString()),
                            junio = int.Parse(dr["junio"].ToString()),

                        });
                    }
                }

                return lista;
            }
        }

        public List<Servicio> ListarTodos2(int anio)
        {
            List<Servicio> lista = new List<Servicio>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Servicio2 where periodo='agosto-diciembre' and anio=@anio " +
                    "order by julio desc, agosto desc, septiembre desc, octubre desc, noviembre desc, diciembre desc";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@anio", anio));

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Servicio()
                        {
                            idServicio = int.Parse(dr["idServicio"].ToString()),
                            descripcion = dr["descripcion"].ToString(),
                            tipoServicio = dr["tipo"].ToString(),
                            periodo = dr["periodo"].ToString(),
                            anio = int.Parse(dr["anio"].ToString()),
                            idArea = int.Parse(dr["idArea"].ToString()),
                            julio = int.Parse(dr["julio"].ToString()),
                            agosto = int.Parse(dr["agosto"].ToString()),
                            septiembre = int.Parse(dr["septiembre"].ToString()),
                            octubre = int.Parse(dr["octubre"].ToString()),
                            noviembre = int.Parse(dr["noviembre"].ToString()),
                            diciembre = int.Parse(dr["diciembre"].ToString()),
                        });
                    }
                }

                return lista;
            }
        }


    }
}
