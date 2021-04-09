using CNP_MVVM.ViewModel;
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

namespace CNP_MVVM.View
{
    /// <summary>
    /// Interaction logic for CustomDateView.xaml
    /// </summary>
    public partial class CustomDateView : Window
    {
        public CustomDateView()
        {
            InitializeComponent();
        }

        private void Combobox_Luni_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = sender as ComboBox;
            var b = a.SelectedIndex;


            var c = 2;
        }
    }
}