using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace prakta1entity
{
    /// <summary>
    /// Логика взаимодействия для OrdersWindow.xaml
    /// </summary>
    public partial class OrdersWindow : Window
    {
        private Prakta1Entities dbContext = new Prakta1Entities();

        public OrdersWindow()
        {
            InitializeComponent();
            DataContext = this;
            LoadOrders();
        }

        public ObservableCollection<Orders> Orders { get; set; }

        private void LoadOrders()
        {
            Orders = new ObservableCollection<Orders>(dbContext.Orders.ToList());
        }
    }
}