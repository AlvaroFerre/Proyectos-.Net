using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Modelos
{
    public class PActivo
    {
        public int Id { get; set; }
        public Vehiculos Vehiculo { get; set; }
        public DateTime HEntrada { get; set; }
        public DateTime HSalida { get; set; }

        public override string ToString()
        {

            return $"ID Parking Activo: #{Id} \n" +
                $"Matricula: #{Vehiculo?.Matricula} \n" +
                    $"Hora de Entrada: {HEntrada} \n" +
                    $"Hora de Salida: {HSalida}";
        }
    }
}
