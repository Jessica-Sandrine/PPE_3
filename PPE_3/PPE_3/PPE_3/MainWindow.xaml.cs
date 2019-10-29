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

//librairie MySql ajouté précedement dans les réferences 
using MySql.Data.MySqlClient;

namespace PPE_3
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*MySqlConnection connexion = new MySqlConnection("database=shoptaphoto; server=127.0.0.1; uid=root; pwd=root;");
            try
            {
                connexion.Open();
                MessageBox.Show("connecté");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Non connecté" + ex.Message);
            }
            */
            Facture w1 = new Facture();
            w1.Show();

        }
    }
}
