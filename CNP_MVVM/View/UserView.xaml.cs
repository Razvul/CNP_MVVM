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
using CNP_MVVM.Model;
using CNP_MVVM.Utilities;
using Newtonsoft.Json;

namespace CNP_MVVM.View
{
    /// <summary>
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserView : Window
    {
        private User _user;
        private readonly UserDatabase _userDatabase = UserDatabase.GetInstance();
        private readonly bool _isNewUser = false;

        public UserView(User utilizator)
        {
            InitializeComponent();
            _user = utilizator;
            Button_Add.Visibility = Visibility.Hidden;
            this.DataContext = DataContext;
        }

        public UserView()
        {
            InitializeComponent();
            _isNewUser = true;
            Button_Delete.Visibility = Visibility.Hidden;
            Button_Update.Visibility = Visibility.Hidden;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //if (_isNewUser)
            //{
            //    _user = new User()
            //    {
            //        Id = Utility.GetNewId().ToString(),
            //        Person = new PersonClass(),
            //        Address = new AddressClass()
            //    };

            //    PopulateNewUser();
            //}
            //else
            //{
            //    Populate();
            //}
            //TextBox_ID.IsEnabled = false;
        }

        #region Butoane
        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Update_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Functii
        private void Populate()
        {
            ComboBox_Sex.ItemsSource = Enum.GetValues(typeof(GenderEnums));

            if (_user?.Person.Sex == GenderEnums.Feminin)
            {
                ComboBox_Sex.SelectedIndex = 1;
            }
            else
            {
                ComboBox_Sex.SelectedIndex = 0;
            }

            TextBox_ID.Text = $"{_user?.Id}";
            TextBox_Nume.Text = $"{_user?.Person.Nume}";
            TextBox_Prenume.Text = $"{_user?.Person.Prenume}";
            TextBox_CNP.Text = $"{_user?.Person.CNP}" == "0" ? "" : $"{_user?.Person.CNP}";
            TextBox_Oras.Text = $"{_user?.Address.Oras}";
            TextBox_Strada.Text = $"{_user?.Address.Strada}";
            TextBox_Numar.Text = $"{_user?.Address.Numar}" == "0" ? "" : $"{_user?.Address.Numar}";
            TextBox_Bloc.Text = $"{_user?.Address.Bloc}";
            TextBox_Scara.Text = $"{_user?.Address.Scara}";
            TextBox_Etaj.Text = $"{_user?.Address.Etaj}" == "0" ? "" : $"{_user?.Address.Etaj}";
            TextBox_Apartament.Text = $"{_user?.Address.Apartament}" == "0" ? "" : $"{_user?.Address.Apartament}";
            TextBox_Judet.Text = $"{_user?.Address.Judet}";
            TextBox_CodPostal.Text = $"{_user?.Address.CodPostal}" == "0" ? "" : $"{_user?.Address.CodPostal}";
        }

        private void PopulateNewUser()
        {
            ComboBox_Sex.ItemsSource = Enum.GetValues(typeof(GenderEnums));
            ComboBox_Sex.SelectedIndex = 1;

            TextBox_ID.Text = $"{_user.Id}";
            TextBox_Nume.Text = string.Empty;
            TextBox_Prenume.Text = string.Empty;
            TextBox_CNP.Text = string.Empty;
            TextBox_Oras.Text = string.Empty;
            TextBox_Strada.Text = string.Empty;
            TextBox_Numar.Text = string.Empty;
            TextBox_Bloc.Text = string.Empty;
            TextBox_Scara.Text = string.Empty;
            TextBox_Etaj.Text = string.Empty;
            TextBox_Apartament.Text = string.Empty;
            TextBox_Judet.Text = string.Empty;
            TextBox_CodPostal.Text = string.Empty;
        }

        private void GetUserFromForm()
        {
            _user.Person.Nume = TextBox_Nume.Text;
            _user.Person.Prenume = TextBox_Prenume.Text;
            _user.Person.Sex = ComboBox_Sex.SelectedIndex == 0 ? GenderEnums.Masculin : GenderEnums.Feminin;
            _user.Person.CNP = long.TryParse(TextBox_CNP.Text, out long rezultat) ? rezultat : 0;
            _user.Address.Oras = TextBox_Oras.Text;
            _user.Address.Strada = TextBox_Strada.Text;
            _user.Address.Numar = int.TryParse(TextBox_Numar.Text, out int resultat) ? resultat : 0;
            _user.Address.Bloc = TextBox_Bloc.Text;
            _user.Address.Scara = TextBox_Scara.Text;
            _user.Address.Etaj = int.TryParse(TextBox_Etaj.Text, out int result) ? result : 0;
            _user.Address.Apartament = int.TryParse(TextBox_Apartament.Text, out int res) ? res : 0;
            _user.Address.Judet = TextBox_Judet.Text;
            _user.Address.CodPostal = int.TryParse(TextBox_CodPostal.Text, out int r) ? r : 0;

            _user.DisplayValue = $"{_user.Person.Nume} {_user.Person.Prenume}";
        }
        #endregion
    }
}