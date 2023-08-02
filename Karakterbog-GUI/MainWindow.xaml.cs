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
using Microsoft.Data.SqlClient;

namespace Karakterbog_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Tilføj_knap_Click(object sender, RoutedEventArgs e)
        {
            //string connectionString = "Data Source=moniespc;Initial Catalog=Karakterbog;Intergrated Security=True";
            string connectionString = "Server=localhost;Database=Karakterbog;Trusted_Connection=True;TrustServerCertificate=True;";
            int mat = Convert.ToInt32(Matematik.Text);
            int dan = Convert.ToInt32(Dansk.Text);
            int eng = Convert.ToInt32(Englesk.Text);
            string sqlQuery = "INSERT INTO Table_Karakterbog(Navn, Karakter_Mat, Karakter_Dan, Karakter_Eng) VALUES ( " + Navn.Text + ", " + mat + ", " + dan + ", "+eng+");";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}