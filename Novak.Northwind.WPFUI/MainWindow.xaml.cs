using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Novak.Northwind.WPFUI
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

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            //List<NorthwindService.CCustomer> oCustomers = new List<NorthwindService.CCustomer>();

            //NorthwindService.NorthwindClient oClient = new NorthwindService.NorthwindClient();

            //oCustomers = oClient.GetCustomers();

            //grdCustomers.ItemsSource = null;
            //grdCustomers.ItemsSource = oCustomers;

            //oClient = null;
        }
    }
}
