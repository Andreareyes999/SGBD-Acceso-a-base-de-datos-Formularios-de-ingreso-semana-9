using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace primer_parcial___equipo_5
{
    public partial class Crearcuenta : Form
    {
        public Crearcuenta()
        {
            InitializeComponent();
        }

        private void UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.formulario_de_ingresoDataSet);

        }

        private void Crearcuenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'formulario_de_ingresoDataSet.Users' Puede moverla o quitarla según sea necesario.
            this.usersTableAdapter.Fill(this.formulario_de_ingresoDataSet.Users);
            txtusuario.Focus();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string pass = txtpass.Text;

            if (usuario == "" || pass == "")
            {
                MessageBox.Show("debe de completar los campos para completar el registro");
            }
            else
            {
                usersTableAdapter.agregar_usuario(usuario, pass);
                this.usersTableAdapter.Fill(this.formulario_de_ingresoDataSet.Users);
                MessageBox.Show("Datos agregados con exito");

            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtusuario.Text = txtpass.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string pass = txtpass.Text;

            if (usuario == "" || pass == "")
            {
                MessageBox.Show("Bebe de completar los campos para completar el registro");
            }
            else
            {
                usersTableAdapter.actualizar_usuario(usuario, pass, usuario);
                this.usersTableAdapter.Fill(this.formulario_de_ingresoDataSet.Users);
                MessageBox.Show("Datos agregados con exito");

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string pass = txtpass.Text;

            if (usuario == "")
            {
                MessageBox.Show("Debe de seleccionar al menos un usuario para ser eliminado");
            }
            else
            {

                string message = "Esta realmente seguro que desea eliminar el usuario";
                string title = "Eliminar Usuario";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    usersTableAdapter.eliminar_usuario(usuario);
                    this.usersTableAdapter.Fill(this.formulario_de_ingresoDataSet.Users);
                    MessageBox.Show("Datos Eliminado con exito");
                }
                



               

            }
        }
    }
}
