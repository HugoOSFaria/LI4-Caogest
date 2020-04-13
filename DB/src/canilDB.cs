using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CaoGest.src
{
    public class canilDB
    {
         //---------------------------------------------------------------------INSERTS-----------------------------------------------------------------------
        //Insere um novo canil
        public static void insereCanil(string email, string nib, string nome, int capacidadeOcupada, int capacidadeTotal, string password, string distrito, string rua, string localidade,string contacto)
        {
            try
            {
                DbConnect dB = new DbConnect();
                string query = "INSERT INTO Canil (Email,NIB,Nome,CapacidadeOcupada,CapacidadeTotal,Password,Distrito,Rua,Localidade,Contacto) VALUES (" + "'" + email + "'" + ", " + "'" + nib + "'" + ", " + "'" + nome + "'" + "," + capacidadeOcupada + ", " + capacidadeTotal + ", " + "'" + password + "'" + ", " + "'" + distrito + "'" + ", " + "'" + rua + "'" + "," + "'" + localidade + "'" +","+ "'"+contacto+"'"+")";

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


        //UPDATE capacidade Total 
        public static void updateCapacidadeT(string email, int capacidadeTot)
        {
            try
            {
                DbConnect dB = new DbConnect();
                string query = "UPDATE Canil SET CapacidadeTotal="+capacidadeTot+" WHERE Canil.Email="+"'"+email+"'";

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

        //UPDATE capacidade Ocupada
        public static void updateCapacidadeO(string email, int capacidadeOcup)
        {
            try
            {
                DbConnect dB = new DbConnect();
                string query = "UPDATE Canil SET CapacidadeOcupada=" + capacidadeOcup + " WHERE Canil.Email=" + "'" + email + "'";

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

        //UPDATE Password
        public static void updatePass(string email, string newPass)
        {
            try
            {
                DbConnect dB = new DbConnect();
                string query = "UPDATE Canil SET Password=" +"'"+newPass+"'"+ " WHERE Canil.Email=" + "'" + email + "'";

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


        //UPDATE Contacto
        public static void updateContacto(string email, string newContacto)
        {
            try
            {   
                DbConnect dB = new DbConnect();
                string query = "UPDATE Canil SET Contacto=" + "'" + newContacto + "'" + " WHERE Canil.Email=" + "'" + email + "'";

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
        public static void deleteCanil(string email)
        {
            try
            {
                DbConnect dB = new DbConnect();
                string query = "DELETE FROM Canil WHERE Email="+"'"+email+"'";

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

        //Select statement

            public static List<string> SelectCanil(string email)
            {
            DbConnect dB = new DbConnect();
            string query = "SELECT * FROM Canil WHERE Email="+"'"+email+"'";

                //Create a list to store the result
                List<string> list = new List<string>();
                //Open connection
                if (dB.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, dB.getConnection());
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                    list.Add((string)dataReader["NIB"]);
                    list.Add((string)dataReader["NOME"]);
                    int x= (int)dataReader["CapacidadeOcupada"];
                    list.Add(x.ToString());
                    int y= (int)dataReader["CapacidadeTotal"];
                    list.Add(y.ToString());
                    list.Add((string)dataReader["Password"]);
                    list.Add((string)dataReader["Distrito"]);
                    list.Add((string)dataReader["Rua"]);
                    list.Add((string)dataReader["Localidade"]);
                    list.Add((string)dataReader["Contacto"]);             

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
        /*  COM LISTA
        //Retorna os identificadores de parcerias de um determinado canil
        public static List<String> SelectParcerias(string email)
        {
            List<String> list = new List<String>();
            try { 
            DbConnect dB = new DbConnect();
            string query = "SELECT * from Parceria JOIN Canil_has_Parceria ON Parceria_Identificacao=Identificacao WHERE Canil_Email=" + "'" + email + "'";

            //Create a list to store the result

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

                        int x = (int)dataReader["Identificacao"];
                        list.Add(x.ToString());
                        list.Add((string)dataReader["Nome"]);
                        list.Add((string)dataReader["Url"]);
                        list.Add((string)dataReader["PathLogo"]);
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
            return list;
        }
    */




       
        public static List<List<String>> SelectParcerias(string email)
        {
       
            List<List<String>> list = new List<List<String>>();            
            try
            {
                DbConnect dB = new DbConnect();
                string query = "SELECT * from Parceria JOIN Canil_has_Parceria ON Parceria_Identificacao=Identificacao WHERE Canil_Email=" + "'" + email + "'";

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
                        int x = (int)dataReader["Identificacao"];
                        subList.Add(x.ToString());
                        subList.Add((string)dataReader["Nome"]);
                        subList.Add((string)dataReader["Url"]);
                        subList.Add((string)dataReader["PathLogo"]);
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
            return list;
        }


        //Retorna os 
        public static List<List<String>> SelectCaes(string email)
        {

            List<List<String>> list = new List<List<String>>();
            try
            {
                DbConnect dB = new DbConnect();
                string query = "SELECT * from Cao JOIN Canil ON Canil_Email=Email WHERE Email=" + "'" + email + "'";

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

        public static bool containsKey(string key)
        {
            try
            {
                DbConnect dB = new DbConnect();
                string query = "SELECT COUNT(*) FROM Canil WHERE Email = '" + key + "'";

                //open connection
                if (dB.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dB.getConnection());

                    //Execute command
                    Int32 valor = Convert.ToInt32(cmd.ExecuteScalar());

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
                string query = "SELECT Password FROM Canil WHERE Email = '" + (String)key + "'";

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


