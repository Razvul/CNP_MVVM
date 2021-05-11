using CNP_MVVM.Annotations;
using CNP_MVVM.Model;
using CNP_MVVM.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CNP_MVVM.ViewModel
{
    class MainWindowViewModel:INotifyPropertyChanged
    {
        private readonly UserDatabase _userDatabase = UserDatabase.GetInstance();

        private string _cautare;

        public string Cautare
        {
            get { return _cautare; }
            set
            {
                _cautare = value;
                OnPropertyChanged(nameof(Cautare));
            }
        }
       

        public ObservableCollection<string> Test()
        {
            var userlist= _userDatabase.GetUserList();
            var a = new ObservableCollection<string>();
            

            foreach (var user in userlist.OrderBy(d=>d.Person.Nume))
            {
                a.Add(user.DisplayValue);
            }
            return a;
        }

        private ObservableCollection<string> _listaUser;

        public ObservableCollection<string> ListaUser
        {
            get
            {
                _listaUser = Test();
                return _listaUser;
            }
            set
            {
                _listaUser = value;
                OnPropertyChanged(nameof(ListaUser));
            }
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}