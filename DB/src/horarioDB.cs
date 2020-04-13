﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CaoGest.src
{
    class horarioDB
    {

        public static void registaHorario( DateTime inicio, DateTime fim,string emailUser, string emailCanil)
        {
            try
            {
                string sqlFormattedDateI = inicio.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string sqlFormattedDateF = fim.ToString("yyyy-MM-dd HH:mm:ss.fff");

                DbConnect dB = new DbConnect();
                string query = "INSERT INTO HCU VALUES ('"+sqlFormattedDateI+"'"+"," +"'"+ sqlFormattedDateF +"'"+","+"'"+emailUser+"'"+","+"'"+emailCanil+"'"+")";
               

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

        public static void criaHorario(DateTime inicio, DateTime fim,string emailC, int limite)
        {
            try
            {
                string sqlFormattedDateI = inicio.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string sqlFormattedDateF = fim.ToString("yyyy-MM-dd HH:mm:ss.fff");

                DbConnect dB = new DbConnect();
                string query = "INSERT  INTO  Horario VALUES ("+ "'" + sqlFormattedDateI + "'" + "," + "'" + sqlFormattedDateF + "'" +","+ "'" +emailC+"'"+","+limite+ ")";
                

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

        //Dá todos os horários de um dado canil
        public static List<List<String>> selectHorarios(string emailCanil)
        {

            List<List<String>> list = new List<List<String>>();
            try
            {
                DbConnect dB = new DbConnect();
                string query = "SELECT * from Horario WHERE Canil_Email=" + "'" + emailCanil + "'";

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

                        string s = (dataReader["DataInicio"].ToString());
                        subList.Add(s);

                        string s1 = (dataReader["DataFim"].ToString());
                        subList.Add(s1);

                        subList.Add((string)dataReader["Canil_Email"]);
                        int x = (int)dataReader["Capacidade"];
                        subList.Add(x.ToString());

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
            catch (System.InvalidCastException) { }
            catch (System.IndexOutOfRangeException) { }
          
            return list;
        }
    }
}
