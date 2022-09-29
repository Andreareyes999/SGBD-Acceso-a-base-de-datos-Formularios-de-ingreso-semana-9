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
    public partial class Nuevospagina2 : Form
    {
        public Nuevospagina2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Compras();

            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Compras();

            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new Compras();

            form.Show();
        }

        private void Nuevospagina2_Load(object sender, EventArgs e)
        {

        }
    }
}
