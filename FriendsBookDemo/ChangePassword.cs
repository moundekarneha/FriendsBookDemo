using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FriendsBookDemo.DataOperation;

namespace FriendsBookDemo
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        //validating text
        private bool validateText()
        {
            bool checkEmptyText = true;
            if (txtUsernameChangePass.Text.Trim() == "")
            {
                checkEmptyText = false;
                MessageBox.Show("Please enter username");
                return checkEmptyText;
            }
            else
            {
                if (txtPasswordPrevious.Text.Trim() == "")
                {
                    checkEmptyText = false;
                    MessageBox.Show("Please enter password");
                    return checkEmptyText;
                }
                else
                {
                    if(txtNewConfirmPassword.Text.Trim()=="")
                    {
                        checkEmptyText = false;
                        MessageBox.Show("Please enter confirm password");
                        return checkEmptyText;
                    }
                    else
                    {
                        if(txtNewPassword.Text.Trim()=="")
                        {
                            checkEmptyText = false;
                            MessageBox.Show("Please enter new password");
                            return checkEmptyText;
                        }
                        else
                        {
                            if (txtNewConfirmPassword.Text.Trim() != txtNewConfirmPassword.Text.Trim())
                            {
                                checkEmptyText = false;
                                MessageBox.Show("Please enter matching password");
                                return checkEmptyText;
                            }
                            else
                            {
                                return checkEmptyText;
                            }

                        }
                    }
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
        //change password logic
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                Global global = new Global();
                if (validateText())
                {
                    
                        if (global.checkLogin(txtUsernameChangePass.Text, txtPasswordPrevious.Text))
                        {
                            if (checkUsername(txtUsernameChangePass.Text))
                            {
                                if (checkPassword(txtPasswordPrevious.Text))
                                {
                                    string strsql = "update Registration set pwd='"+txtNewConfirmPassword.Text+"'where username='"+txtUsernameChangePass.Text+"'";
                                    global.runNonQuery(strsql);
                                    MessageBox.Show("Password updated successfully...");
                                    Login login = new Login();
                                    login.Show();
                                    this.Hide();

                                }
                                else
                                {
                                    MessageBox.Show("Updation failed...");
                                }
                            }

                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
