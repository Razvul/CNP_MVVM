using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CNP_MVVM.Annotations;

namespace CNP_MVVM.Model
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            { 
                _firstName = value; 
                OnPropertyChanged(FirstName);
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            { 
                _lastName = value; 
                OnPropertyChanged(LastName);
            }
        }

        private string _fullName;

        public string FullName
        {
            get { return _fullName = $"{FirstName} {LastName}"; }
            set
            {
                if (_fullName != value)
                {
                    _fullName = value; 
                    OnPropertyChanged(FullName);
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}