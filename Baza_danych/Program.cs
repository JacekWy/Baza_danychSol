using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Baza_danych
{
    class Program
    {
        static void Main(string[] args)

        {
            Baza_class connect = new Baza_class();

            connect.connect_data();
            connect.show_data();

            string namee = "Kamil";
            string pass = "Kamil12";
            string insert_query = "INSERT INTO user (Name,Passwd) VALUES ('"+namee+"','"+pass+"')";

            Console.WriteLine(insert_query);
            
            Console.ReadKey();
        }
    }
}
