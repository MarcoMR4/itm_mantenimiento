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

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into Servicio2(descripcion,tipo,periodo,anio,idArea) values (@descripcion,@tipo,@periodo,@anio,@idArea)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@descripcion", obj.descripcion));
                cmd.Parameters.Add(new SQLiteParameter("@tipo", obj.tipoServicio));
                cmd.Parameters.Add(new SQLiteParameter("@periodo", obj.periodo));
                cmd.Parameters.Add(new SQLiteParameter("@anio", obj.anio));
                cmd.Parameters.Add(new SQLiteParameter("@idArea", obj.idArea));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

        //Read 
        public List<Servicio> Listar(int idArea1)
        {
            List<Servicio> lista = new List<Servicio>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Servicio2 where idArea=@idArea";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@idArea", idArea1));

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
                            idArea = int.Parse(dr["idArea"].ToString())
                        });
                    }
                }

                return lista;
            }
        }
    }
}
