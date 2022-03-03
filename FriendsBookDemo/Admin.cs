using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FriendsBookDemo
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        //showing info of all friends
        private void showUserFriends()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"data source=LAPTOP-F5BLCG31\SQLEXPRESS; initial catalog=FriendsBook; integrated security=true;";
            sqlConnection.Open();
            string strsql = "select * from Friends";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strsql, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "dt");
            DataGridShowToAdmin.DataSource = dataSet.Tables["dt"];
            sqlConnection.Close();
        }
        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        
        private void btnAllFriends_Click(object sender, EventArgs e)
        {
            showUserFriends();
        }
    }
}
