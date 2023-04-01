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
    /// Логика взаимодействия для Prodic.xaml
    /// </summary>
    public partial class Prodic : Window
    {
        ProductTableAdapter productTableAdapter = new ProductTableAdapter();
        public Prodic()
        {
            InitializeComponent();
            Produc.ItemsSource = productTableAdapter.GetData();
        }

        private void Produc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
