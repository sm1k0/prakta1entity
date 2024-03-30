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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        private Prakta1Entities dbContext = new Prakta1Entities();

        public ProductsWindow()
        {
            InitializeComponent();
            DataContext = this;
            LoadProducts();
        }

        public ObservableCollection<Products> Products { get; set; }

        private void LoadProducts()
        {
            Products = new ObservableCollection<Products>(dbContext.Products.ToList());
        }
    }
}
