using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;



namespace primer_parcial___equipo_5
{
    public partial class iniciarseccion : Form
    {
        public iniciarseccion()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=LAPTOP-C6KTNLFR;database=formulario_ingreso; integrated security=true");
        OleDbConnection conexionacceses = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\formulario_de_ingreso.accdb");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iniciarseccion_Load(object sender, EventArgs e)
        {
            conexionacceses.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string pass = txtpass.Text;

            if (usuario == "" || pass == "")
            {
                MessageBox.Show("Debe de completar los campos para poder continuar");
            }
            else
            {
                string consulta_access = "select * from Users where user = '" + usuario + "' and password = '" + pass + "'";
                OleDbCommand comando = new OleDbCommand(consulta_access, conexionacceses);
                OleDbDataReader leeraccess;
                leeraccess = comando.ExecuteReader();
                Boolean siexiste = leeraccess.HasRows;
                if (siexiste)
                {
                    MessageBox.Show("bienvendo al Sistema " + usuario);
                    Form1 abrirnuevo = new Form1();
                    // abrirnuevo.recuperarValores("Se a iniciado seccion desde Access");
                    abrirnuevo.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error Datos Incorectos");
                    //conexionacceses.Close();
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            //conexionacceses.Open();
            string usuario = txtusuario.Text;
            string pass = txtpass.Text;

            if (usuario == "" || pass == "")
            {
                MessageBox.Show("Debe de completar los campos para poder continuar");
            }
            else
            {
                string consulta_access = "select * from Users where user = '" + usuario + "' and password = '" + pass + "'";
                OleDbCommand comando = new OleDbCommand(consulta_access, conexionacceses);
                OleDbDataReader leeraccess;
                leeraccess = comando.ExecuteReader();
                Boolean siexiste = leeraccess.HasRows;
                if (siexiste)
                {
                    MessageBox.Show("bienvendo al Sistema " + usuario);
                    Form1 abrirnuevo = new Form1();
                    // abrirnuevo.recuperarValores("Se a iniciado seccion desde Access");
                    abrirnuevo.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error Datos Incorectos");
                    //conexionacceses.Close();
                }
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string pass = txtpass.Text;

            if (usuario == "" || pass == "")
            {
                MessageBox.Show("Debe de completar los campos para poder continuar");
            }
            else
            {
                conexion.Open();
                String consulta_sql = "select * from usuario where usuario = '" + usuario + "' and password = '" + pass + "'";
                SqlCommand comando = new SqlCommand(consulta_sql, conexion);
                SqlDataReader leersql;
                leersql = comando.ExecuteReader();

                if (leersql.HasRows == true)
                {
                    MessageBox.Show("bienvendo al Sistema " + usuario);
                    Form1 abrirnuevo = new Form1();
                    //abrirnuevo.recuperarValores("Se a iniciado seccion desde SQL Server");
                    abrirnuevo.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Los Datos son incorectos");

                }
            }
        }
    }
}
