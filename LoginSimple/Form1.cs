using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;




namespace LoginSimple
{
    public partial class Form1 : Form

    {
      
        public Form1()
        {
            InitializeComponent();
        }
        public void login()
        {
            SqlConnection conexion = new SqlConnection("Data Source=NOELDRUMS17;Initial Catalog=login;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT username, password FROM usuarios WHERE username='" + txtUser.Text + "' AND password ='" + txtPassword.Text + "'", conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login exitoso");
                
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
            conexion.Close();
        }
        public void limpiar()
        {
            txtUser.Clear();
            txtPassword.Clear();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void btnAcces_Click(object sender, EventArgs e)
        {
           
            login();
            limpiar();
           
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
     
        }
    }
}
