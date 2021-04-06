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
using CNP_MVVM.View;

namespace CNP_MVVM
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

        private void Add_Person_Test_Click(object sender, RoutedEventArgs e)
        {
            var a = new AddPersonWindow();
            a.ShowDialog();
        }

        private void CNP_Test_Click(object sender, RoutedEventArgs e)
        {
            var a = new CNPView();
            a.ShowDialog();
        }

        private void Data_Click(object sender, RoutedEventArgs e)
        {
            var a = new CustomDateView();
            a.ShowDialog();
        }
    }
}