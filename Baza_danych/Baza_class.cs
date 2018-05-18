using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_danych
{
    public class Baza_class
    {
        static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=baza;SslMode=none;";
        MySqlConnection conn = new MySqlConnection(connectionString);

        public void connect_data()
        {

            try
            {
                conn.Open();
                Console.WriteLine("Udalo sie poloczyc z bazo");
            }
            catch
            {
                Console.WriteLine("Nie udalo sie poloczyc z bazą");
                conn.Close();
            }


        }
        public void show_data()
        {
            string query = "select * from user";
            MySqlCommand command = new MySqlCommand(query, conn);

            MySqlDataReader read;
            read = command.ExecuteReader();

            try
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        int id = read.GetInt32(0);
                        string name = read.GetString(1);
                        string passwd = read.GetString(2);

                        Console.WriteLine("id= {0} name= {1} passwd= {2}", id, name, passwd);

                    }

                }
                conn.Close();
            }
            catch
            {

                Console.WriteLine("Nie udało sie pokazac danych");
                conn.Close();
            }

        }
        public void insert_data()
        {
            string namee;
            string pass;

            Console.WriteLine("Dodawanie uzytkownika");
            namee = Console.ReadLine();
            Console.WriteLine("Password");
            pass = Console.ReadLine();

            Console.WriteLine("Dodajesz: " + namee +" czy na pewno chszesz dodac tego uzytkownika");


            string insert_query = "INSERT INTO user (Name,Passwd) VALUES ('" + namee + "','" + pass + "')";

            MySqlCommand insert = new MySqlCommand(insert_query, conn);
            try
            {
                insert.ExecuteNonQuery();
                Console.WriteLine("Udało sie wprowadzic urzytkownika i password");
            }
            catch
            {
                Console.WriteLine("nie udało sie");
            }


        }
    }
}
