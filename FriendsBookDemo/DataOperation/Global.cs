using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FriendsBookDemo.DataOperation
{
    public class Global
    {
        public static int loginId;
        
        //getting login id after logged in - for adding friends of particular user.
       public void GetLoginId(string userName)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"data source=LAPTOP-F5BLCG31\SQLEXPRESS; initial catalog=FriendsBook; integrated security=true;";
            sqlConnection.Open();
            string strsql = "select loginid from Registration where Username='" + userName + "'";
            SqlCommand sqlCommand = new SqlCommand(strsql, sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.Read())
            {
                loginId = int.Parse(dataReader[0].ToString());
            }

            sqlConnection.Close();   
        }

        public bool checkLogin(string userName, string password)
        {
            bool loginStatus = false;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"data source=LAPTOP-F5BLCG31\SQLEXPRESS; initial catalog=FriendsBook; integrated security=true;";
            sqlConnection.Open();
            if(userName!="Admin" && password!="admin")
            {
                
                string strsql = "select * from Registration where Username='" + userName + "' and Pwd='" + password + "'";
                SqlCommand sqlCommand = new SqlCommand(strsql, sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    loginStatus = true;   
                    
                }

                sqlConnection.Close();
            }
           
            return loginStatus;

        }
        
        //checking for already added user
        public bool checkWhileRegistration(string username)
        {
           
                bool flag = false;
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = @"data source=LAPTOP-F5BLCG31\SQLEXPRESS; initial catalog=FriendsBook; integrated security=true;";
                sqlConnection.Open();
                string strsql = "select * from Registration";
                SqlCommand sqlCommand = new SqlCommand(strsql, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if(sqlDataReader[1].ToString()==username)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                return flag;
        }
        public void runNonQuery(string strsql)
        {
            
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"data source=LAPTOP-F5BLCG31\SQLEXPRESS; initial catalog=FriendsBook; integrated security=true;";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(strsql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            
        }

    }
}
