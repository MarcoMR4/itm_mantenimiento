﻿using mantenimiento_proyecto.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantenimiento_proyecto.Logica
{
    internal class HallazgoLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static HallazgoLogica _instancia = null;

        public HallazgoLogica() { }

        public static HallazgoLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new HallazgoLogica();
                }
                return _instancia;
            }
        }

        public bool Guardar(Hallazgo obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into Hallazgo(descripcion,idEspacio,atendido, idListaVerificacion) values (@descripcion,@idEspacio,@atendido,@idLista)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@descripcion", obj.descripcion));
                cmd.Parameters.Add(new SQLiteParameter("@idEspacio", obj.idEspacio));
                cmd.Parameters.Add(new SQLiteParameter("@atendido", obj.atendido));
                cmd.Parameters.Add(new SQLiteParameter("@idLista", 1));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

        public List<Hallazgo> Listar(int idEspacio1)
        {
            List<Hallazgo> lista = new List<Hallazgo>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Hallazgo where idEspacio=@idEspacio";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@idEspacio", idEspacio1));

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Hallazgo()
                        {
                            idHallazgo = int.Parse(dr["idHallazgo"].ToString()),
                            idEspacio = int.Parse(dr["idEspacio"].ToString()),
                            descripcion = dr["descripcion"].ToString(),
                            atendido = dr["atendido"].ToString()
                        });
                    }
                }

                return lista;
            }
        }

    }
}
