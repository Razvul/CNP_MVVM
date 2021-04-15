using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNP_MVVM.Model;
using CNP_MVVM.Annotations;
using System.Runtime.CompilerServices;
using CNP_MVVM.Utilities;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CNP_MVVM.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public UserViewModel()
        {
            _user = new User
            {
                Id="1573",
                Person=new PersonClass
                {
                    Nume="matrggfe",
                    Prenume="htrd",
                    CNP=1234456
                },
                Address=new AddressClass
                {
                    Oras="orgrimar",
                    Apartament=2
                }
            };
        }

        private User _user;
        
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged(nameof(User));
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