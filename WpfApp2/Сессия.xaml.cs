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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Сессия.xaml
    /// </summary>
    public partial class Сессия : Window
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader reader;

        public Сессия()
        {
            InitializeComponent();
            cnn = new SqlConnection(@"Data Source=Vc-stud-mssql1;User ID=user93_db;Password=user93");
        }

        private void fed1_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void fed1_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void fed1_Loaded_2(object sender, RoutedEventArgs e)
        {

        }

        private void fed1_Loaded_3(object sender, RoutedEventArgs e)
        {
            string query = "Select * from Product";
            cnn.Open();
            cmd = new SqlCommand(query, cnn);
            reader = cmd.ExecuteReader();
            DataTable def = new DataTable();
            SqlDataAdapter def1 = new SqlDataAdapter();
            def1.Fill(def);
            if (reader.Read())
            {
                fed2.title.Text = GetValue(1);
            }

            cmd.Dispose();
            cnn.Close();
 
        }

        private void fed1_Loaded_4(object sender, RoutedEventArgs e)
        {

        }

        private void fed1_Loaded_5(object sender, RoutedEventArgs e)
        {

        }
    }
}
