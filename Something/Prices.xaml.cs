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
using Something.ProdDataSetTableAdapters;

namespace Something
{
    /// <summary>
    /// Логика взаимодействия для Prices.xaml
    /// </summary>
    public partial class Prices : Window
    {
        PriceTableAdapter priceTableAdapter = new PriceTableAdapter();
        public Prices()
        {
            InitializeComponent();
            Pric.ItemsSource = priceTableAdapter.GetData();
        }

        private void Pric_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
