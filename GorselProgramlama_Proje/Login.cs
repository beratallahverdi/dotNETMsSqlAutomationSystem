using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama_Proje
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Enter code here for your version of username and userpassword 
        LoginForm login = new LoginForm("berat", "sifre");


        private void loginButton_Click(object sender, EventArgs e)
        {
            //define local variables from the user inputs 
            string user = loginTextBox.Text;
            string pass = passwordTextBox.Text;
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
                Homepage homeForm = new Homepage();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                //show default login error message 
                MessageBox.Show("GİRİŞ BAŞARISIZ");
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
