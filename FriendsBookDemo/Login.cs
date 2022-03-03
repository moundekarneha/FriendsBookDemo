using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FriendsBookDemo.DataOperation;
using System.Text.RegularExpressions;

namespace FriendsBookDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool validateText()
        {
            bool checkEmptyText = true;
            if (txtUsernameLogin.Text.Trim() == "")
            {
                checkEmptyText = false;
                MessageBox.Show("Please enter username");
                return checkEmptyText;
            }
            else
            {
                if (txtPasswordLogin.Text.Trim() == "")
                {
                    checkEmptyText = false;
                    MessageBox.Show("Please enter password");
                    return checkEmptyText;
                }
                else
                {
                    return checkEmptyText;
                }
            }
            
           
        }
        private bool checkUsername(string username)
        {
            bool valid = false;
            /*^[A-z] --> Look for a string that starts with a letter

            [A-z --> followed by a letter

            |\. --> or a dot

            |\s] --> or a space

            + --> at list one time

            $ --> that's the end of the string */
            Regex regex = new Regex(@"^[A-z][A-z|\.|\s]+$");
            valid = regex.IsMatch(username) ? true : false;
            return valid;
        }
        //checking password 
        private bool checkPassword(string password)
        {

            int validConditions = 0;
            foreach (char c in password)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 0) return false;
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 1) return false;
            if (validConditions == 2)
            {
                char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' }; // or whatever    
                if (password.IndexOfAny(special) == -1) return false;
            }
            return true;

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            { 
                Global global = new Global();
                if(validateText())
                {
                    if (txtUsernameLogin.Text.Trim() == "Admin" && txtPasswordLogin.Text.Trim() == "admin")
                    {
                        MessageBox.Show("Logged in...");
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (global.checkLogin(txtUsernameLogin.Text, txtPasswordLogin.Text))
                        {
                            if(checkUsername(txtUsernameLogin.Text))
                            {
                                if(checkPassword(txtPasswordLogin.Text))
                                {
                                    string strsql = "update Registration set flag='1' where (username!='Admin' and pwd!='admin')";
                                    global.runNonQuery(strsql);
                                    MessageBox.Show("Logged in...");
                                    global.GetLoginId(txtUsernameLogin.Text);
                                    FriendsInformation friendsInformation = new FriendsInformation();
                                    friendsInformation.Show();
                                    this.Hide();
                                }
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Login Failed...");
                        }
                    }
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
            this.Hide();
                
        }

        private void linkLabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
