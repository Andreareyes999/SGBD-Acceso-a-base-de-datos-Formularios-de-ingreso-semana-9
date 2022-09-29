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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void nuevosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Nuevospagina2();
            form.MdiParent = this;
            form.Show();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Descuantospagina3();
            form.MdiParent = this;
            form.Show();
        }

        private void comidaDeGatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Gatopagina4();
            form.MdiParent = this;
            form.Show();
        }

        private void comidaDePerroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Perropagina5();
            form.MdiParent = this;
            form.Show();
        }

        private void juguetesDeGatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new juguetesgatopagina6();
            form.MdiParent = this;
            form.Show(); 
        }

        private void juguetesDePerroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Juguetesperropagina7();
            form.MdiParent = this;
            form.Show(); 
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Ayuda();
            form.MdiParent = this;
            form.Show(); 
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string message = "Esta realmente seguro que desea Salir";
            string title = "Salir";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

            //Form form = new Salir();
            //form.MdiParent = this;
            //form.Show();
        }

        private void cCuadroDeDialogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Cuadropagina9();
            form.MdiParent = this;
            form.Show(); 
        }

        private void ayudaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form form = new Ayuda();
            form.MdiParent = this;
            form.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Acercade();
            form.MdiParent = this;
            form.Show(); 
        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Crearcuenta();
            form.MdiParent = this;
            form.Show(); 
        }

        private void iniciarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new iniciarseccion();
            form.MdiParent = this;
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
