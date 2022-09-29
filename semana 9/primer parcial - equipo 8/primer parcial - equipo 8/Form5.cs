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
    public partial class Perropagina5 : Form
    {
        public Perropagina5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Compras();

            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Compras();

            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Compras();

            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Compras();

            form.Show();
        }
    }
}
