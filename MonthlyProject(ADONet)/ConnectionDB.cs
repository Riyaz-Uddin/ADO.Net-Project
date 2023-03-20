using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyProject_ADONet_
{
    class ConnectionDB
    {
        public ConnectionStringSettings customer; //app.config 
        public SqlConnection connection1;//database connection 
        public SqlCommand cmd1; //command--insert,update,delete......
        public void conn1(string a)
        {
            customer = ConfigurationManager.ConnectionStrings["exam"];
            //app.config 
            connection1 = new
               SqlConnection(); //sql database connection
            connection1.ConnectionString = customer.ConnectionString;
            cmd1 = connection1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = a;
            connection1.Open();
        }
    }
}
