﻿using System;
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

            using (SQLiteConnection conexion = new SQLiteConnection(cadena)) {
                conexion.Open();
                string query = "insert into Area(nombre) values (@nombre)";

                SQLiteCommand cmd = new SQLiteCommand(query,conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.nombre));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
                return respuesta;
        }

        public List<Area> Listar() 
        {       
            List<Area> lista = new List<Area>();

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
                            nombre = dr["nombre"].ToString()
                        });
                    }
                }

                return lista;
            }
        }

    }
}