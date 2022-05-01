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
using tuto1.ViewModel;

namespace tuto1.View
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientViewModel cvm = new ClientViewModel();
        public MainWindow()
        {
            InitializeComponent();
            listBox.ItemsSource = cvm.GetLesClients();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listBox.ItemsSource = cvm.GetLesClients();
            MessageBox.Show(" " + listBox.SelectedIndex);
            if (listBox.SelectedIndex == -1)
            {
                cvm.setLeClient(cvm.GetLesClients()[0]);
            }
            else
            {
                cvm.setLeClient(cvm.GetLesClients()[listBox.SelectedIndex]);
            }
        }

        private void btn_modifier_Click(object sender, RoutedEventArgs e)
        {
            if (cvm.getLeClient() != null)
            {
                cvm.Update(cvm.getLeClient());
            }
            else
            {
                cvm.setLeClient(new model.client());
                cvm.getLeClient().code_c = Convert.ToInt32(tb_code.Text);
                cvm.getLeClient().nom = tb_nom.Text;
                cvm.getLeClient().adresse = tb_adresse.Text;
                cvm.getLeClient().telephone = tb_telephone.Text;
                cvm.getLeClient().cp = Convert.ToInt32(tb_cp.Text);
                cvm.getLeClient().ville = tb_ville.Text;
                MessageBox.Show(cvm.getLeClient().nom.ToString());
                if (cvm.Insert(cvm.getLeClient()))
                {
                    listBox.ItemsSource = cvm.GetLesClients();
                }
            }
        }

        private void btn_supprimer_Click(object sender, RoutedEventArgs e)
        {
            if (cvm.Delete(cvm.getLeClient()))
            {
                cvm.GetLesClients().Remove(cvm.getLeClient());
                if (listBox.SelectedIndex == -1)
                {
                    listBox.SelectedIndex = 0;
                    cvm.setLeClient(cvm.GetLesClients()[listBox.SelectedIndex]);
                }
                listBox.ItemsSource = cvm.GetLesClients(); //Pour raffraichir
            }
        }


        private void btn_ajouter_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO produits (id, nom, prix, image) values (lId, leNom, lePrix, lImage");
            //cmd.Parameters.AddWithValue("lId",valeur);
        }

        private void btn_creer_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
