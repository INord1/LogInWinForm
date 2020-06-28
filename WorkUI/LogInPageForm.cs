using CheckInAndManagmentLibrary;
using CheckInAndManagmentLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkUI
{
    public partial class LogInPageForm : Form
    {
        public LogInPageForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {




            SqlConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Work"));

            SqlCommand cmd = new SqlCommand("spCheckCredentials", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@LogIn", txtLogin.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            connection.Open();
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();

            if (read.HasRows)
            {
                WelcomeForm welcomeForm = new WelcomeForm(); welcomeForm.ShowDialog(); this.Close();

            }
            else MessageBox.Show("Error");
            connection.Close();

            //PersonModel model = new PersonModel = new PersonModel(txtLogin.Text, txtPassword.Text);

            //GlobalConfig.Connections.CheckLogInandPassword(autntification);





        }
        private bool ValidateForm()
        {
            bool output = true;




            if (txtPassword.Text.Length < 5)
            {
                MessageBox.Show("Password should be logner than 5 didgits");
                output = false;
            }

            return output;

        }
    }
}
