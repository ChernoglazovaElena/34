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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.bdDataSetTableAdapters;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        clothesTableAdapter sss = new clothesTableAdapter ();



        public MainWindow()
        {

            InitializeComponent();
            clothesDataGrid.ItemsSource = sss.GetData();
            
        }

        private void clothes1_Click_1(object sender, RoutedEventArgs e)
        {
            sss.InsertAppend(clothes2.Text);
            clothesDataGrid.ItemsSource = sss.GetData();
        }

        private void MC_Click(object sender, RoutedEventArgs e)
        {
            Window1 wi1 = new Window1 ();
            wi1.ShowDialog ();
        }

        private void MC1_Click(object sender, RoutedEventArgs e)
        {
            Window2 wi2 = new Window2();
            wi2.ShowDialog();
        }

        private void D_Click(object sender, RoutedEventArgs e)
        {
            object Del = (clothesDataGrid.SelectedItem as DataRowView).Row[0];
            sss.DeleteDelet(Convert.ToInt32(Del));
            clothesDataGrid.ItemsSource = sss.GetData(); 
        }

        private void Iz_Click(object sender, RoutedEventArgs e)
        {
            object Izm = (clothesDataGrid.SelectedItem as DataRowView).Row[0];
            sss.UpdateUptad(clothes2.Text, Convert.ToInt32(Izm));
            clothesDataGrid.ItemsSource = sss.GetData();
        }

        private void clothesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((clothesDataGrid.SelectedItem as DataRowView) != null)
            {
                clothes2.Text = (clothesDataGrid.SelectedItem as DataRowView).Row[1].ToString();
                 
            }
        }

        
    }
}
