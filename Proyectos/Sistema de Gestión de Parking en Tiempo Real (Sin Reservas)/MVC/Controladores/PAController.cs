using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carreras;
using Microsoft.Data.SqlClient;
using Parking.Modelos;

namespace Parking.Controladores
{
    public class PAController
    {
        public bool NuevaEntrada(PActivo v)
        {
            // Inicializo la conexion a la base de datos
            using (var conn = new DbConn().GetConexion())
                try
                {
                    // Abro la conexion
                    conn.Open();

                    // Genero la consulta
                    string sql = "INSERT INTO ParkingActivo (matricula) VALUES (@matricula)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@matricula", v.Vehiculo.Matricula);

                    // Ejecuto la consulta y devulvo true or false en funcion de la lineas afectadas
                    if (cmd.ExecuteNonQuery() > 0) { 
                        return true; 
                    }
                    else
                    {
                        return false;
                    }
                   
                }
                catch (Exception ex) { MessageBox.Show($"Error en tiempo de insercion: {ex.ToString()}"); return false; }
        }

        public bool RegSalida(PActivo v)
        {
            // Inicializo la conexion a la base de datos
            using (var conn = new DbConn().GetConexion())
                try
                {
                    // Abro la conexion
                    conn.Open();

                    // Genero la consultas
                    string sql = "UPDATE ParkingActivo SET HoraSalida = @HS WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@matricula", v.Vehiculo.Matricula);

                    // Ejecuto la consulta y devulvo true or false en funcion de la lineas afectadas
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex) { MessageBox.Show($"Error en tiempo de insercion: {ex.ToString()}"); return false; }
        }

        public PActivo GetPA(string matricula)
        {
            // Inicializo el controlador de vahiculos para traerme el objeto de tipo vehiculo
            VehiculosController vh = new VehiculosController();
            Vehiculos vehiculo = vh.GetVehiculo(matricula);

            // Si el objeto es nulo muestro mensaje de error
            if (vehiculo == null)
            {
                MessageBox.Show("No existe ese vehiculo en la base de datos");
            }
            // Inicializo la conexion a la base de datos
            using (var conn = new DbConn().GetConexion())
                try
                {
                    // Abro la conexion
                    conn.Open();

                    // Genero la consulta
                    string sql = "SELECT * FROM ParkingActivo WHERE matricula = @matricula";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@matricula", matricula);

                    // Ejecuto la consulta y devuelvo el objeto
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    PActivo pa = new PActivo()
                    {
                        Id = (int)reader[0],
                        Vehiculo = vehiculo,
                        HEntrada = (DateTime)reader[2],
                        HSalida = (DateTime)reader[3]
                    };
                    return pa;
                }
                catch (Exception ex) { MessageBox.Show($"Error en tiempo de insercion: {ex.ToString()}"); return null; }

            
        }

        public List<PActivo> GetListaActivos()
        {
            VehiculosController vc = new VehiculosController();
            List<PActivo> lista = new List<PActivo>();
            // Inicializo la conexion a la base de datos
            using (var conn = new DbConn().GetConexion())
                try
                {
                    // Abro la conexion
                    conn.Open();

                    // Genero la consulta
                    string sql = "SELECT * FROM ParkingActivo WHERE HoraSalida IS NULL";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Ejecuto la consulta y devuelvo el objeto
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        Vehiculos v = vc.GetVehiculoById((int)reader[0]);
                        PActivo pa = new PActivo()
                        {
                            Id = (int)reader[0],
                            Vehiculo = v,
                            HEntrada = (DateTime)reader[2],
                            HSalida = (DateTime)reader[3]
                        };
                        lista.Add(pa);
                    }
                    
                    return lista;
                }
                catch (Exception ex) { MessageBox.Show($"Error en tiempo de recuperacion: {ex.ToString()}"); return null; }
            
        }
        public List<PActivo> ListHistoricos(string fecha, string matricula) {
            VehiculosController vc = new VehiculosController();
            List<PActivo> lista = new List<PActivo>();
            // Inicializo la conexion a la base de datos
            using (var conn = new DbConn().GetConexion())
                try
                {
                    // Abro la conexion
                    conn.Open();

                    // Genero la consulta
                    string sql = "SELECT * FROM ParkingActivo WHERE FechaSalida = @fecha OR matricula = @matricula";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Ejecuto la consulta y devuelvo el objeto
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Vehiculos v = vc.GetVehiculoById((int)reader[0]);
                        PActivo pa = new PActivo()
                        {
                            Id = (int)reader[0],
                            Vehiculo = v,
                            HEntrada = (DateTime)reader[2],
                            HSalida = (DateTime)reader[3]
                        };
                        lista.Add(pa);
                    }

                    return lista;
                }
                catch (Exception ex) { MessageBox.Show($"Error en tiempo de recuperacion: {ex.ToString()}"); return null; }
        }
    }
}
