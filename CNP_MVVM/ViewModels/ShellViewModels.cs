using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNP_MVVM.ViewModels
{
    public class ShellViewModels : ViewModelBase
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                this.RaisePropertyChanged("FirstName");
            }
        }

    }
}