using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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

namespace prakta1entity
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ClientsButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new ClientsWindow());
        }

        private void ProductsButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new ProductsWindow());
        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new OrdersWindow());
        }

        private void OrderRecipientsButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new OrderRecipientWindow());
        }

        private void DeliveryButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new DeliveryWindow());
        }

        private void OpenWindow(Window window)
        {
            window.Owner = this;
            window.Show();
        }
    }
}