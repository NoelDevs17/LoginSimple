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
        SqlConnection con = new SqlConnection("Data Source=NOELDRUMS17;Initial Catalog=login;Integrated Security=True");



        public Form1()
        {
            InitializeComponent();
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
            con.Open();
        }
    }
}
