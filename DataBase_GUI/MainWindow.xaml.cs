using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBase_GUI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Show_Table_Click(object sender, RoutedEventArgs e)
        {
            
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=baza;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

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

                        Show.Text = id.ToString() + name.ToString() + passwd.ToString();
                        
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

        

        
    }
}

