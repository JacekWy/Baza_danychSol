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
            //connect.insert_data();
            connect.show_data();

            
            Console.ReadKey();
        }

    }
}
