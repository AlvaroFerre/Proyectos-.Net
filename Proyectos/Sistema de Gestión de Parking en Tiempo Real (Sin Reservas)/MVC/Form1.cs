using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RES_Click(object sender, EventArgs e)
        {
            // Inicializo el formulario de gestion de entradas y salidas lo muesto y luego oculto la pantalla de inicio
            GestES_cs es = new GestES_cs();
            es.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Inicializo el formulario de gestion de entradas y salidas lo muesto y luego oculto la pantalla de inicio
            FormListados fl = new FormListados();
            fl.Show();
            this.Hide();
        }
    }
}
