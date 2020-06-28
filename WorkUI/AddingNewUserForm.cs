using CheckInAndManagmentLibrary;
using CheckInAndManagmentLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkUI
{
    public partial class AddingNewUserForm : Form
    {
        public AddingNewUserForm()
        {
            InitializeComponent();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel model = new PersonModel(txtLogin.Text,
                    txtPassword.Text, txtFirstName.Text, txtLastName.Text,
                    txtEmail.Text, txtPhoneNumber.Text);

                GlobalConfig.Connections.CreatePeron(model);

            }






        }


        private bool ValidateForm()
        {
            bool output = true;

            int placePhoneNumber = 0;
            bool placeValidPhoneNumber = int.TryParse(txtPhoneNumber.Text, out placePhoneNumber);


            if(!placeValidPhoneNumber)
            {
                MessageBox.Show("Enter Only Numbers for a Phone Number Field");
                output =false;
            }

            if(txtPhoneNumber.Text.Length<10)
            {
                MessageBox.Show("Phone Number Shoud Include 10 digits");
                output = false;
            }

            if (txtPassword.Text.Length < 5)
            {
                MessageBox.Show("Password should be logner than 5 didgits");
                output = false;
            }

            return output;

        }
    }
}
