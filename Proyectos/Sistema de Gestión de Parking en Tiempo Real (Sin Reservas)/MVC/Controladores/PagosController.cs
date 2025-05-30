using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carreras;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Parking.Modelos;
using System.Runtime.InteropServices;

namespace Parking.Controladores
{
    public class PagosController
    {
        public bool Insercion(Pagos p)
        {
            // Inicializo la conexion a la base de datos
            using (var conn = new DbConn().GetConexion())
                try
                {
                    // Abro la conexion
                    conn.Open();

                    // Genero la consulta
                    string sql = "INSERT INTO Pagos (ParkingId, Importe, MetodoPago) VALUES (@ParkingId, @importe, @mp)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ParkingId", p.Parking.Id);
                    cmd.Parameters.AddWithValue("@importe", p.Importe);
                    cmd.Parameters.AddWithValue("@mp", p.MetodoPago);

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

        public Pagos NewPago(PActivo vpac)
        {
            // Calcular la diferencia de tiempo
            TimeSpan diferencia = vpac.HSalida - vpac.HEntrada;

            // Convertir TotalHours (double) a decimal
            decimal horas = (decimal)diferencia.TotalHours;

            // Redondear hacia arriba para cobrar cada hora completa o fracción
            decimal horasRedondeadas = Math.Ceiling(horas);

            // Calcular el importe: 2 unidades monetarias por hora
            decimal importe = horasRedondeadas * 2m;

            // Devolver el objeto de pago
            return new Pagos()
            {
                Parking = vpac,
                Importe = importe,
                MetodoPago = "Tarjeta",
                Fecha = DateTime.Now
            };
        }

    }
}
