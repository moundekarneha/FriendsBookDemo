using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FriendsBookDemo.DataOperation;
using System.Text.RegularExpressions;


namespace FriendsBookDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
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
            Regex regex =new Regex(@"^[A-z][A-z|\.|\s]+$");
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
        //Infornation of registration should not be null
        private bool validateText()
        {
            bool checkEmptyText = true;
            if (txtUsername.Text.Trim() == "")
            {
                checkEmptyText = false;
                MessageBox.Show("Please enter username");
                return checkEmptyText;   
            }
            else
            {
                if (txtPassword.Text.Trim() == "")
                {
                    checkEmptyText = false;
                    MessageBox.Show("Please enter password");
                    return checkEmptyText;
                }
                else
                {
                    if (txtConfirmPassword.Text.Trim() == "")
                    {
                        checkEmptyText = false;
                        MessageBox.Show("Please enter confirm password");
                        return checkEmptyText;
                    }
                    else
                    {
                        if (comboSecurityQuestions.SelectedIndex == -1)
                        {
                            checkEmptyText = false;
                            MessageBox.Show("Please select security question");
                            return checkEmptyText;
                        }
                        else
                        {
                            if (txtSecurityAnswer.Text.Trim() == "")
                            {
                                checkEmptyText = false;
                                MessageBox.Show("Please enter security answer");
                                return checkEmptyText;
                            }
                            else
                            {
                                if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                                {
                                    checkEmptyText = false;
                                    MessageBox.Show("Please enter correct password");
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
           
          
        }

        //Clearing Text
         private void clearText()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtSecurityAnswer.Text = "";
            comboSecurityQuestions.Text = "";
        }

        //Going to login page
        private void goToLoginPage()
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Global global = new Global();
            if (validateText())
            {
                if(checkUsername(txtUsername.Text))
                {if(checkPassword(txtPassword.Text))
                    {
                        if (global.checkWhileRegistration(txtUsername.Text))
                        {
                            MessageBox.Show("Already Registered. \n Please register with another username");
                            clearText(); //for clearing text
                        }
                        else
                        {
                            string strsql = "insert into Registration values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + comboSecurityQuestions.Text + "','" + txtSecurityAnswer.Text + "','1')";
                            global.runNonQuery(strsql);
                            MessageBox.Show("User Registered Successfully...");
                            clearText(); //for clearing text
                            goToLoginPage(); //going to login page
                        }
                    }
                else
                    {
                        MessageBox.Show("please enter valid password");
                    }
                }
                else
                {
                    MessageBox.Show("please enter valid username");
                }

            }


        }
    }
}
