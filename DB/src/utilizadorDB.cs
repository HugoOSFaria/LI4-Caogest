using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace CaoGest.src
{
    public class utilizadorDB
    {
        //-----------------------------------------------------------------------------------INSERT---------------------------------------------------------------------------
        public static void insereUser(string email, string nome, string password, DateTime nasc, string distrito, string rua, string localidade, string cc,string sexo)
        {
            try
            {
                DbConnect dB = new DbConnect();
                string sqlFormattedDate = nasc.ToString("yyyy-MM-dd HH:mm:ss.fff");
                //  Console.Write(email+","+nome+","+password+","+distrito+","+rua+","+localidade+","+cc+","+sexo+'\n');
                // Console.Write(nasc);
                string query = "INSERT INTO Utilizador (Email,Nome,Password,Data_de_Nascimento,Distrito,Rua,Localidade,CC,Sexo) VALUES (" + "'" + email + "'" + ", " + "'" + nome + "'" + ", " + "'" + password + "'" + ", " + "'" + sqlFormattedDate + "'" + ", " + "'" + distrito + "'" + "," + "'" + rua + "'" + "," + "'" + localidade + "'" + "," + "'" + cc + "'"  + ","+"'"+sexo+"'"+")";
                Console.Write(query);
                //open connection
                if (dB.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dB.getConnection());

                    //Execute command
                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteScalar();

                    //close connection
                    dB.CloseConnection();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException) { };

        }



        //---------------------------------------------------------------------DELETS-----------------------------------------------------------------------

        //DELETE Canil
        public static void deleteUser(string email)
        {
            try
            {
                DbConnect dB = new DbConnect();
                string query = "DELETE FROM Utilizador WHERE Email=" + "'" + email + "'";

                //open connection
                if (dB.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dB.getConnection());

                    //Execute command
                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteScalar();

                    //close connection
                    dB.CloseConnection();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException) { };

        }

        //---------------------------------------------------------------------UPDATES-----------------------------------------------------------------------

        //UPDATE Password
        public static void updatePass(string email, string newPass)
        {
            try
            {
                DbConnect dB = new DbConnect();
                string query = "UPDATE Utilizador SET Password=" + "'" + newPass + "'" + " WHERE Utilizador.Email=" + "'" + email + "'";

                //open connection
                if (dB.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dB.getConnection());

                    //Execute command
                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteScalar();

                    //close connection
                    dB.CloseConnection();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException) { };

        }

        //UPDATE Email
        public static void updateEmail(string email, string newContacto)
        {
            try
            {
                DbConnect dB = new DbConnect();
                string query = "UPDATE Utilizador SET Email=" + "'" + newContacto + "'" + " WHERE Utilizador.Email=" + "'" + email + "'";

                //open connection
                if (dB.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dB.getConnection());

                    //Execute command
                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteScalar();

                    //close connection
                    dB.CloseConnection();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException) { };

        }

        //---------------------------------------------------------------------SELECTS-----------------------------------------------------------------------

        public static bool containsKey(string key)
        {
            try
            {
                DbConnect dB = new DbConnect();
                string query = "SELECT COUNT(*) FROM Utilizador WHERE Email = '" +key + "'";

                //open connection
                if (dB.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dB.getConnection());

                    //Execute command
                    Int32 valor  = Convert.ToInt32(cmd.ExecuteScalar());

                    //close connection
                    dB.CloseConnection();

                    if (valor == 0)
                    {
                        return false;
                    }
                    else return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException) { };
            return false;
        }

        public static bool valPass(string key, string value)
        {
            try
            {
                DbConnect dB = new DbConnect();
                string query = "SELECT Password FROM Utilizador WHERE Email = '" + (String)key + "'";

                //open connection
                if (dB.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dB.getConnection());

                    String res = null;

                    //Execute command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        res = (string)dataReader["Password"];
                    }
                    //cmd.ExecuteScalar();

                    dataReader.Close();
                    //close connection
                    dB.CloseConnection();

                    if (res == value)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException) { };
            return false;
        }

       

       
    }
}
