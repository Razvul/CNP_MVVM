using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CNP_MVVM.Annotations;
using CNP_MVVM.Utilities;

namespace CNP_MVVM.Model
{
    class UserList : INotifyPropertyChanged
    {

        #region Persoana
        private GenderEnums _gender;

        public GenderEnums Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        private long _cnp;

        public long CNP
        {
            get { return _cnp; }
            set
            {
                _cnp = value;
                OnPropertyChanged(nameof(CNP));
            }
        }
        #endregion

        #region Adresa
        private string _oras;

        public string Oras
        {
            get { return _oras; }
            set
            {
                _oras = value;
                OnPropertyChanged(nameof(Oras));
            }
        }

        private string _strada;

        public string Strada
        {
            get { return _strada; }
            set
            {
                _strada = value;
                OnPropertyChanged(nameof(Strada));
            }
        }

        private int _numar;

        public int Numar
        {
            get { return _numar; }
            set
            {
                _numar = value;
                OnPropertyChanged(nameof(Numar));
            }
        }

        private string _bloc;

        public string Bloc
        {
            get { return _bloc; }
            set
            {
                _bloc = value;
                OnPropertyChanged(nameof(Bloc));
            }
        }

        private string _scara;

        public string Scara
        {
            get { return _scara; }
            set
            {
                _scara = value;
                OnPropertyChanged(nameof(Scara));
            }
        }

        private int _etaj;

        public int Etaj
        {
            get { return _etaj; }
            set
            { 
               _etaj = value;
                OnPropertyChanged(nameof(Etaj));
            }
        }

        private int _apartament;

        public int Apartament
        {
            get { return _apartament; }
            set
            {
                _apartament = value;
                OnPropertyChanged(nameof(Apartament));
            }
        }

        private string _judet;

        public string Judet
        {
            get { return _judet; }
            set
            {
                _judet = value;
                OnPropertyChanged(nameof(Judet));
            }
        }

        private int _codPostal;   

        public int CodPostal
        {
            get { return _codPostal; }
            set
            {
                _codPostal = value;
                OnPropertyChanged(nameof(CodPostal));
            }
        }
        #endregion

        private User _utilizator;

        public User Utilizator
        {
            get { return _utilizator; }
            set
            {
                _utilizator = value;
                OnPropertyChanged(nameof(Utilizator));
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