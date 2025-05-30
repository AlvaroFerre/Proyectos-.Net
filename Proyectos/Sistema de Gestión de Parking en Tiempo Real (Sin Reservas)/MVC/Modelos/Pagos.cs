using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Modelos
{
    public class Pagos
    {
        public int Id { get; set; }
        public PActivo Parking { get; set; }
        public decimal Importe { get; set; }
        public string MetodoPago { get; set; }
        public DateTime Fecha { get; set; }

        public override string ToString()
        {

            return $"ID Parking Activo: #{Id} \n" +
                    $"Matricula: #{Parking?.Id} \n" +
                    $"Importe total: {Importe}" +
                    $"Metodo de Pago: {MetodoPago} \n" +
                    $"Fecha del Pago: {Fecha}";
        }
    }
}
