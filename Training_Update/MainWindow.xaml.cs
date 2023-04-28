using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Training_Update
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RetoursViewModel dvdViewModel;
        public MainWindow()
        {
            InitializeComponent();
            dvdViewModel = new RetoursViewModel();
            DataContext = dvdViewModel;

            // teste
            DataContext = new RetoursViewModel();

        }


        private void add_click(object sender, RoutedEventArgs e)
        {
            ajout ad = new ajout();
            ad.ShowDialog();
        }

        private void DVDListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            retours selectedDVD = (retours)DVDListView.SelectedItem;
            // dvdViewModel.DeleteDVD(selectedDVD);


            // teste 




            if (selectedDVD != null)
            {
                MessageBoxResult result = MessageBox.Show("Voulez-vous modifier cet élément ?", "Modifier l'élément", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    ModificationWindow modificationWindow = new ModificationWindow(selectedDVD);
                    modificationWindow.ShowDialog();
                    // actualiser la liste des retours après la modification
                    dvdViewModel.RefreshList();
                }
            }

        }
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as RetoursViewModel).RefreshList();
        }



        //test


       

        }

    }



















