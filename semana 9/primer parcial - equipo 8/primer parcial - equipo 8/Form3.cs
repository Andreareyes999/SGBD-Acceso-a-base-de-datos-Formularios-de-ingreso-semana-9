using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primer_parcial___equipo_5
{
    public partial class Descuantospagina3 : Form
    {
        public Descuantospagina3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Compras();

            form.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Compras();

            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Compras();

            form.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
