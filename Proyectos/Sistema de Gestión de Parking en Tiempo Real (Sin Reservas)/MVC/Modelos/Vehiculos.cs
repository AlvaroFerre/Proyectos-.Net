using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Modelos
{
    public class Vehiculos
    {
        public string Matricula {  get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public override string ToString()
        {

            return $"Matricula: #{Matricula} \n" +
                    $"Marca: {Marca} \n" +
                    $"Modelo: {Modelo}";
        }
    }
}
