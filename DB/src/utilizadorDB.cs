using System;
using System.Collections.Generic;
namespace CaoGest.src
{

    public class utilizadorDB{
        //-----------------------------------------------------------------------------------INSERT---------------------------------------------------------------------------
        public static void insereUser(string email, string nome, string password, DateTime nasc, string distrito, string rua, string localidade, int cc){
            try{
                DbConnect dB = new DbConnect();
                string query = "INSERT INTO Utilizador (Email,Nome,Password,Data_de_Nascimento,Distrito,Rua,Localidade,CC) VALUES (" + "'" + email + "'" + ", " + "'" + nome + "'" + ", " + "'" + password + "'" + ", " + "'" + nasc + "'" + ", " + "'" + distrito + "'" + "," + "'" + rua + "'" + "," + "'" + localidade + "'" + "," + "'" + cc + "'" + ")";

                //open connection
                if (dB.OpenConnection() == true){
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
        public static void updatePass(string email, string newPass){
            try{
                DbConnect dB = new DbConnect();
                string query = "UPDATE Utilizador SET Password=" + "'" + newPass + "'" + " WHERE Utilizador.Email=" + "'" + email + "'";

                //open connection
                if (dB.OpenConnection() == true){
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
        public static void updateEmail(string email, string newContacto){
            try{
                DbConnect dB = new DbConnect();
                string query = "UPDATE Email SET Email=" + "'" + newContacto + "'" + " WHERE Utilizador.Email=" + "'" + email + "'";

                //open connection
                if (dB.OpenConnection() == true){
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

        public static bool containsKey(string key){
            try{
                DbConnect dB = new DbConnect();
                string query = "SELECT Email FROM Utilizador WHERE Email = '" + (String)key + "'";

                //open connection
                if (dB.OpenConnection() == true){
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dB.getConnection());

                    String res = null;

                    //Execute command
                    MySqlDataReader dataReader = cmd.ExecuteNonQuery();
                    while (dataReader.Read()){
                        res = (string)dataReader["Email"];
                    }
                    //cmd.ExecuteScalar();

                    dataReader.Close();
                    //close connection
                    dB.CloseConnection();

                    if (res == query){
                        return true;
                    }
                    else return false;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException) { };
            return false;
        }

        public static bool valPass(string key, string value){
            try{
                DbConnect dB = new DbConnect();
                string query = "SELECT Password FROM Utilizador WHERE Email = '" + (String)key + "'";

                //open connection
                if (dB.OpenConnection() == true){
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dB.getConnection());

                    String res = null;

                    //Execute command
                    MySqlDataReader dataReader = cmd.ExecuteNonQuery();
                    while (dataReader.Read()){
                        res = (string)dataReader["Password"];
                    }
                    //cmd.ExecuteScalar();

                    dataReader.Close();
                    //close connection
                    dB.CloseConnection();

                    if (res == value){
                        return true;
                    }
                    else return false;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException) { };
            return false;
        }

        public static List<List<String>> pesquisaCaes(string raca, int idade, char sexo, string cor, char porte){
            List<List<String>> list = new List<List<String>>();
            try{
                DbConnect dB = new DbConnect();
                string query = "SELECT * from Cao WHERE idCao=idCao AND Raça=" + "'" + raca + "'" + "AND Idade=" + "'" + idade + "'" + "AND Sexo=" + "'" + sexo + "'" + "AND cor=" + "'" + cor + "'" + "AND Porte=" + "'" + porte + "'";

                //Open connection
                if (dB.OpenConnection() == true)
                {

                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, dB.getConnection());
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    int i = 0;
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        List<String> subList = new List<String>();
                        int x = (int)dataReader["IdCao"];
                        subList.Add(x.ToString());
                        subList.Add((string)dataReader["Nome"]);
                        subList.Add((string)dataReader["Sexo"]);
                        subList.Add((string)dataReader["Descricao"]);
                        int y = (int)dataReader["Estado"];
                        subList.Add(y.ToString());
                        subList.Add((string)dataReader["Raça"]);
                        subList.Add((string)dataReader["Cor"]);
                        DateTime d = (DateTime)dataReader["DataAdocao"];
                        subList.Add(d.ToString());
                        int z = (int)dataReader["Idade"];
                        subList.Add(z.ToString());
                        bool w = (bool)dataReader["Esterilizacao"];
                        subList.Add(w.ToString());
                        list.Add(subList);
                        i++;


                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    dB.CloseConnection();

                    //return list to be displayed
                    return list;
                }
                else
                {
                    return list;
                }
            }
            catch (System.ArgumentOutOfRangeException) { }
            catch (System.InvalidCastException) { }
            return list;
        }

        public static List<List<String>> pesquisaCaesCanil(string raca, int idade, char sexo, string cor, char porte, string emailC)
        {
            List<List<String>> list = new List<List<String>>();
            try
            {
                DbConnect dB = new DbConnect();
                string query = "SELECT * from Cao WHERE idCao=idCao AND Raça=" + "'" + raca + "'" + "AND Idade=" + "'" + idade + "'" + "AND Sexo=" + "'" + sexo + "'" + "AND cor=" + "'" + cor + "'" + "AND Porte=" + "'" + porte + "'" + "AND CAnil_Email=" + "'" + emailC + "'";

                //Open connection
                if (dB.OpenConnection() == true)
                {

                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, dB.getConnection());
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    int i = 0;
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        List<String> subList = new List<String>();
                        int x = (int)dataReader["IdCao"];
                        subList.Add(x.ToString());
                        subList.Add((string)dataReader["Nome"]);
                        subList.Add((string)dataReader["Sexo"]);
                        subList.Add((string)dataReader["Descricao"]);
                        int y = (int)dataReader["Estado"];
                        subList.Add(y.ToString());
                        subList.Add((string)dataReader["Raça"]);
                        subList.Add((string)dataReader["Cor"]);
                        DateTime d = (DateTime)dataReader["DataAdocao"];
                        subList.Add(d.ToString());
                        int z = (int)dataReader["Idade"];
                        subList.Add(z.ToString());
                        bool w = (bool)dataReader["Esterilizacao"];
                        subList.Add(w.ToString());
                        subList.Add((string)dataReader["Porte"]);
                        list.Add(subList);
                        i++;


                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    dB.CloseConnection();

                    //return list to be displayed
                    return list;
                }
                else
                {
                    return list;
                }
            }
            catch (System.ArgumentOutOfRangeException) { }
            catch (System.InvalidCastException) { }
            return list;
        }
    }
}
