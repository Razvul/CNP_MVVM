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
using CNP_MVVM.Utilities;

namespace CNP_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        private UserDatabase _userDatabase = UserDatabase.GetInstance();

        public MainWindowView()
        {
            InitializeComponent();
        }

        #region Butoane
        private void Add_Person_Test_Click(object sender, RoutedEventArgs e)
        {
            var a = new AddPersonWindow();
            a.ShowDialog();
        }
                
        private void Data_Click(object sender, RoutedEventArgs e)
        {
            var a = new CustomDateView();
            a.ShowDialog();
        }

        private void Buton_Adauga_Click(object sender, RoutedEventArgs e)
        {
            var h = new UserList();
            h.ShowDialog();
        }

        private void Buton_Detalii_Click(object sender, RoutedEventArgs e)
        {
            var SelectedUser = (User)listBox_Users.SelectedItem;
            var gg = new UserList(SelectedUser);
            gg.ShowDialog();
        }
        #endregion
    }
}