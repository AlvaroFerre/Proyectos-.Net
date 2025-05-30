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
    public partial class FormHistoricos : Form
    {
        public FormHistoricos(string fecha, string matricula)
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false; 
            label1.Text = fecha;
            label2.Text = matricula;
            PAController pAController = new PAController();
            List<PActivo> lista = pAController.ListHistoricos(label1.Text, label2.Text);
            dataGridView1.DataSource = lista;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
