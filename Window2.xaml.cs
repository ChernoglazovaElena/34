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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        shoesTableAdapter ddd = new shoesTableAdapter ();
        public Window2()
        {
            InitializeComponent();
            shoesDataGrid.ItemsSource = ddd.GetData();
            clothes2.ItemsSource= ddd.GetData();
            clothes2.DisplayMemberPath = "clothes_id";
            goblin2.ItemsSource = ddd.GetData();
            goblin2.DisplayMemberPath = "goblin_id";
        }

        private void shoes1_Click(object sender, RoutedEventArgs e)
        {
            int m2 = Convert.ToInt32(clothes2.Text);
            int c2 = Convert.ToInt32(goblin2.Text);
            ddd.InsertQueryAppend (m2, c2);
            shoesDataGrid.ItemsSource = ddd.GetData();

        }

        private void D2_Click(object sender, RoutedEventArgs e)
        {
            object Del2 = (shoesDataGrid.SelectedItem as DataRowView).Row[0];
            ddd.DeleteQueryDelet(Convert.ToInt32(Del2));
            shoesDataGrid.ItemsSource = ddd.GetData();
        }

        private void Iz2_Click(object sender, RoutedEventArgs e)
        {
            int m21 = Convert.ToInt32(clothes2.Text);
            int c21 = Convert.ToInt32(goblin2.Text);
            object Izm2 = (shoesDataGrid.SelectedItem as DataRowView).Row[0];
            ddd.UpdateQuery(c21,m21, Convert.ToInt32(Izm2));
            shoesDataGrid.ItemsSource = ddd.GetData();
        }

        private void shoesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((shoesDataGrid.SelectedItem as DataRowView) != null)
            {
            clothes2.Text = (shoesDataGrid.SelectedItem as DataRowView).Row[1].ToString();
            goblin2.Text = (shoesDataGrid.SelectedItem as DataRowView).Row[2].ToString();
            }
           
        }
    }
}
