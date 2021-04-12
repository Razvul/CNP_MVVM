using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CNP_MVVM.Utilities;

namespace CNP_MVVM.View
{
    /// <summary>
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserList : Window
    {
        private readonly User _user;
        //private readonly UserDatabase _userDatabase = UserDatabase.GetInstance();
        private readonly bool _isNewUser = false;

        //public UserList(User user)
        //{
        //    InitializeComponent();
        //    _user = user;
        //    Button_Add.Visibility = Visibility.Hidden;
        //    this.DataContext = DataContext;
        //}

        public UserList()
        {
            InitializeComponent();
            _isNewUser = true;
            Button_Delete.Visibility = Visibility.Hidden;
            Button_Update.Visibility = Visibility.Hidden;
        }       
    }
}