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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3frmBookBon3
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

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {

            if(MessageBox.Show("Do you want to clear Names ?","Warning",MessageBoxButton.YesNo)==MessageBoxResult.Yes)
            {
                lstNames.Items.Clear();
                txtName.Focus();
            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text.Trim();
            if (name.Length > 0)
            {
                lstNames.Items.Add(name);
                txtName.Clear();
                txtName.Focus();


            }
        }
    }
}
