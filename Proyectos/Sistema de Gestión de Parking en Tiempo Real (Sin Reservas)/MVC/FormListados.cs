using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking.Controladores;
using Parking.Modelos;

namespace Parking
{
    public partial class FormListados : Form
    {
        public FormListados()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Inicializo el controlador
            PAController controller = new PAController();
            List<PActivo> list = controller.GetListaActivos();
            dataGridView1.DataSource = list;
        }

        private void HMovsFilters_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null)
            {
                MessageBox.Show("Hay que introducir al menos un parametro");
            }
            FormHistoricos fh = new FormHistoricos(textBox1.Text, textBox2.Text);
            fh.Show();
            this.Hide();
        }
    }
}
