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
    /// Логика взаимодействия для OrderRecipient.xaml
    /// </summary>
    public partial class OrderRecipientWindow : Window
    {
        private Prakta1Entities dbContext = new Prakta1Entities();

        public OrderRecipientWindow()
        {
            InitializeComponent();
            DataContext = this;
            LoadOrderRecipients();
        }

        public ObservableCollection<OrderRecipient> OrderRecipients { get; set; }

        private void LoadOrderRecipients()
        {
            OrderRecipients = new ObservableCollection<OrderRecipient>(dbContext.OrderRecipient.ToList());
        }
    }
}