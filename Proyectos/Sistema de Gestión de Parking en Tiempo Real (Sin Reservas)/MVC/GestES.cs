using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using Parking.Controladores;
using Microsoft.VisualBasic;
using Parking.Modelos;

namespace Parking
{
    public partial class GestES_cs : Form
    {
        public GestES_cs()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegE_Click(object sender, EventArgs e)
        {
            // Pido por pantalla la matricula
            string matricula = Interaction.InputBox("Introduce la Matrucula del vehiculo:", "Entradas", "");

            // Compruebo que no este vacio el campo matricula
            if (matricula != null)
            {
                MessageBox.Show("No puedes poner una matricula vacia");
            }
            // Compruebo que la matricula existe en la base de datos de vehiculos
            //Inicializo el controlador de vehiculos y llamo al metodo que me genera un objeto de tipo vehiculo
            VehiculosController vh = new VehiculosController();
            Vehiculos vehiculo = vh.GetVehiculo(matricula);

            // Si el objeto es nulo muestro mensaje de error
            if (vehiculo == null)
            {
                MessageBox.Show("No existe ese vehiculo en la base de datos");
            }

            // Genero el objeto de PActivo para la insercion posterior
            PActivo obj = new PActivo() { 
                Vehiculo = vehiculo,
                HEntrada = DateTime.Now,
            };

            // Inicializo el controlador de parking activo y llamo al metodo de insercion de entrada
            PAController pac = new PAController();
            if (pac.NuevaEntrada(obj)){
                MessageBox.Show("Insercion OK!");
            } else { MessageBox.Show("Error en la Insercion!"); }
        }

        private void RegS_Click(object sender, EventArgs e)
        {
            // Pido por pantalla la matricula
            string matricula = Interaction.InputBox("Introduce la Matrucula del vehiculo:", "Entradas", "");

            // Compruebo que no este vacio el campo matricula
            if (matricula != null)
            {
                MessageBox.Show("No puedes poner una matricula vacia");
            }
            // Compruebo que la matricula existe en la base de datos de vehiculos
            //Inicializo el controlador de vehiculos y llamo al metodo que me genera un objeto de tipo PActivo
            PAController pac = new PAController();
            PActivo vpac = pac.GetPA(matricula);

            // Si el objeto es nulo muestro mensaje de error
            if (vpac == null)
            {
                MessageBox.Show("No existe Entradas de esa matricula");
            }

            // Inicializo el controlador de parking activo y llamo al metodo que me registra la salida y me inserta en pagos
            if (pac.RegSalida(vpac))
            {
                // Inicializo el controlador de pagos y llamo al metodo de insercion de pagos
                PagosController pc = new PagosController();

                // actualizo el objeto
                vpac = pac.GetPA(matricula);

                // llamo al metedo que me genera el objeto de pagos
                Pagos pagos = pc.NewPago(vpac);
                
                if (pc.Insercion(pagos))
                {
                    // Actualizo el importe de salida
                    ImporteSalida.Text = pagos.Importe + " Eur.";
                    MessageBox.Show("Proceso OK!");
                }
                else
                {
                    MessageBox.Show("Error en la Insercion de Pagos!");
                }
            }
            else { MessageBox.Show("Error en el Proceso!"); }
        }
    }
}
