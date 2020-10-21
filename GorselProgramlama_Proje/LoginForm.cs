using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GorselProgramlama_Proje
{
    class LoginForm
    {
        //decalre properties 
        public string Username { get; set; }
        public string Userpassword { get; set; }

        //intialise  
        public LoginForm(string user, string pass)
        {
            this.Username = user;
            this.Userpassword = pass;
        }
        //clear user inputs 
        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }
        //method to check if eligible to be logged in 
        internal bool IsLoggedIn(string user, string pass)
        {
            //check user name empty 
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("KULLANICI ADI GIRMELISINIZ.");
                return false;

            }
            //check user name is correct 
            else
            {
                if (Username != user)
                {
                    MessageBox.Show("KULLANICI ADI YANLIŞ");
                    ClearTexts(user, pass);
                    return false;
                }
                //check password is empty 
                else
                {
                    if (string.IsNullOrEmpty(pass))
                    {
                        MessageBox.Show("ŞİFRENİZİ GİRMELİSİNİZ");
                        return false;
                    }
                    //check password is correct 
                    else if (Userpassword != pass)
                    {
                        MessageBox.Show("ŞİFRENİZ HATALI");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
