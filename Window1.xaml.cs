using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp1.bdDataSetTableAdapters;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        goblinTableAdapter aaa = new goblinTableAdapter();
        public Window1()
        {
            InitializeComponent();
            goblinDataGrid.ItemsSource = aaa.GetData();
        }

        private void goblin1_Click(object sender, RoutedEventArgs e)
        {
            aaa.Insert1(goblin2.Text);
            goblinDataGrid.ItemsSource = aaa.GetData();
        }

        private void D1_Click(object sender, RoutedEventArgs e)
        {
            object Del1 = (goblinDataGrid.SelectedItem as DataRowView).Row[0];
            aaa.Delete1(Convert.ToInt32(Del1));
            goblinDataGrid.ItemsSource = aaa.GetData();
        }

        private void Iz1_Click(object sender, RoutedEventArgs e)
        {
            object Izm1 = (goblinDataGrid.SelectedItem as DataRowView).Row[0];
            aaa.Update1(goblin2.Text, Convert.ToInt32(Izm1));
            goblinDataGrid.ItemsSource = aaa.GetData();
        }

        private void goblinDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((goblinDataGrid.SelectedItem as DataRowView) != null)
            {
                goblin2.Text = (goblinDataGrid.SelectedItem as DataRowView).Row[1].ToString();

            }
        }
    }
}