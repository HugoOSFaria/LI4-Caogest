using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add MySQL library
using MySql.Data.MySqlClient;

namespace CaoGest.src
{
    class DbConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string dbId;
        private string dbPassword;

        //assign the atributes
        public DbConnect()
        {
            server = "localhost";
            database = "caogest";
            dbId = "root";
            dbPassword = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + dbId + ";" + "PASSWORD=" + dbPassword + ";";
            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection(){
            try
            {
                connection.Open();
                return true; 
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
