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

namespace Training_Update
{
    /// <summary>
    /// Logique d'interaction pour SelectItemsWindow.xaml
    /// </summary>
    public partial class SelectItemsWindow : Window
    {
        public List<retours> SelectedItems { get; private set; }

        public SelectItemsWindow()
        {
            InitializeComponent();
            DataContext = App.ViewModel;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedItems = itemsList.SelectedItems.Cast<retours>().ToList();
            DialogResult = true;
        }
    }
}

