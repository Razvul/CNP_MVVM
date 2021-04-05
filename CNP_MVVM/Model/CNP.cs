using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CNP_MVVM.Annotations;
using CNP_MVVM.Utilities;

namespace CNP_MVVM.Model
{
    public class CNP : INotifyPropertyChanged
    {

        private string _nume;

        public string Nume
        {
            get { return _nume; }
            set
            {
                _nume = value;
                OnPropertyChanged(nameof(Nume));
            }
        }


        private Enums.Gender _gender;

        public Enums.Gender Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
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
