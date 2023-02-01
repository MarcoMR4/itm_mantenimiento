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
