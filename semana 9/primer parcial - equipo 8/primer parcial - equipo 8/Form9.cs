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
    public partial class Cuadropagina9 : Form
    {
        public Cuadropagina9()
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
            MessageBox.Show(" solicitud enviada. Gracias por confiar en Super Patitas Peticion de ayuda enviada exitosamente!!!", " Super Patitas.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Salir();

            form.Show();
        }

        private void Cuadropagina9_Load(object sender, EventArgs e)
        {

        }
    }
}
