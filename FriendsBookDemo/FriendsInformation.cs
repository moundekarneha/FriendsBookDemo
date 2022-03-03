using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using FriendsBookDemo.DataOperation;
using System.Data.SqlClient;

namespace FriendsBookDemo
{
    public partial class FriendsInformation : Form
    {
        public FriendsInformation()
        {
            InitializeComponent();
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private bool validateText()
        {
            bool checkEmptyText = true;
            if (txtFname.Text.Trim() == "")
            {
                checkEmptyText = false;
                MessageBox.Show("Please enter first name");
                return checkEmptyText;
            }
            else
            {
                if (txtLname.Text.Trim() == "")
                {
                    checkEmptyText = false;
                    MessageBox.Show("Please enter last name");
                    return checkEmptyText;
                }
                else
                {
                    if (txtEmilId.Text.Trim() == "")
                    {
                        checkEmptyText = false;
                        MessageBox.Show("Please enter email id");
                        return checkEmptyText;
                    }
                    else
                    {
                        if (txtMobileNum.Text.Trim()=="")
                        {
                            checkEmptyText = false;
                            MessageBox.Show("Please enter mobile number");
                            return checkEmptyText;
                        }
                        else
                        {
                            if (dateTimeDOB.Text.Trim() == "")
                            {
                                checkEmptyText = false;
                                MessageBox.Show("Please enter DOB");
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
        //validate first name
        private bool FirstnameValidation(string fname)
        {
            bool checkFname=true;
            if(Regex.Match(fname,"[0-9]").Success)
            {
                checkFname = false;
            }
            return checkFname;
        }
        //validate last name
        private bool LastnameValidation(string fname)
        {
            bool checkFname = true;
            Regex regex = new Regex("[0-9]");
            if ((regex.IsMatch(fname)))
                checkFname = false;
            return checkFname;
        }

        //validating mail address
        private bool validateMailAddress(string mail)
        {
            bool checkMailAddress = false;
            try
            {
                
                var validateMail = new MailAddress(mail);
                checkMailAddress = validateMail.Host.Contains(".");
                if (checkMailAddress)
                {
                    checkMailAddress = true;
                }
                else
                {
                    checkMailAddress = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return checkMailAddress;
        }

        //validating mobile number
        private bool validateMobileNumber(string mobile)
        {
            bool checkMobileNum = false;
            if(((mobile.Length)<10) || ((mobile.Length)> 10))
            {
                checkMobileNum = false;
            }
            else
            {
                foreach (char c in mobile)
                {
                    if (c < '0' || c > '9')
                    {
                        checkMobileNum = false;
                    }
                    else
                    {
                        checkMobileNum = true;
                    }
                }

            }
            return checkMobileNum;
        }

        //clearing all data
        private void ClearData()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtEmilId.Text = "";
            txtMobileNum.Text = "";
            dateTimeDOB.Text = "";
        }
        //show logged in user friends data
        private void showUserFriends(int loginId)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"data source=LAPTOP-F5BLCG31\SQLEXPRESS; initial catalog=FriendsBook; integrated security=true;";
            sqlConnection.Open();
            string strsql = "select * from Friends where loginid='" + loginId + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strsql, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "dt");
            dataGridFriendsInformation.DataSource = dataSet.Tables["dt"];
            sqlConnection.Close();
        }

        private void btnAddFriendInformation_Click(object sender, EventArgs e)
        {
            Global global = new Global();
            if (validateText())
            {   
                if(FirstnameValidation(txtFname.Text.Trim()))
                {
                    if(LastnameValidation(txtLname.Text.Trim()))
                    {
                        if (validateMailAddress(txtEmilId.Text.Trim()))
                        {
                            if (validateMobileNumber(txtMobileNum.Text.Trim()))
                            {
                                string strsql = "insert into Friends values('"+Global.loginId+"','" + txtFname.Text + "','" + txtLname.Text + "','" + txtEmilId.Text + "','" + txtMobileNum.Text + "','" + dateTimeDOB.Text + "')";
                                global.runNonQuery(strsql);
                                MessageBox.Show("Friends information added Successfully...");
                                ClearData();
                                showUserFriends(Global.loginId);
                            }
                            else
                            {
                                MessageBox.Show("You have entered incorrect mobile number format. Please enter valid mobile number");
                                txtMobileNum.Text = "";
                                txtMobileNum.Focus();
                                return;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid email address");
                            txtEmilId.Text = "";
                            txtEmilId.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digit are not allowed in lasttname. Please enter the text");
                        txtLname.Text = "";
                        txtLname.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Digit are not allowed in firstname. Please enter the text");
                    txtFname.Text = "";
                    txtFname.Focus();
                    return;
                }
            } 
    }

        private void FriendsInformation_Load(object sender, EventArgs e)
        {

        }
    }  
}
