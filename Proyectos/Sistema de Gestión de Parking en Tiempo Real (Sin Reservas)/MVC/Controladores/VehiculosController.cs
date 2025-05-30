using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carreras;
using Microsoft.Data.SqlClient;
using Parking.Modelos;

namespace Parking.Controladores
{
    public class VehiculosController
    {
        public Vehiculos GetVehiculo(string matricula)
        {
            // Inicializo la conexion a la base de datos
            using (var conn = new DbConn().GetConexion())
                try
                {
                    // Abro la conexion
                    conn.Open();

                    // Genero la consulta
                    string sql = "SELECT * FROM vehiculos WHERE matricula = @matricula";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@matricula", matricula); 

                    // Ejecuto la consulta y genero el objeto
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    Vehiculos obj = new Vehiculos() { 
                        Matricula = (string)reader[0],
                        Marca = (string)reader[1],
                        Modelo = (string)reader[2]
                    };


                    return obj;
                }
                catch (Exception ex) { return null; }
        }

        public Vehiculos GetVehiculoById(int v)
        {
            // Inicializo la conexion a la base de datos
            using (var conn = new DbConn().GetConexion())
                try
                {
                    // Abro la conexion
                    conn.Open();

                    // Genero la consulta
                    string sql = "SELECT * FROM vehiculos WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", v);

                    // Ejecuto la consulta y genero el objeto
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    Vehiculos obj = new Vehiculos()
                    {
                        Matricula = (string)reader[0],
                        Marca = (string)reader[1],
                        Modelo = (string)reader[2]
                    };


                    return obj;
                }
                catch (Exception ex) { return null; }
        }
    }
}
