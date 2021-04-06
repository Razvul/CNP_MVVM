using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNP_MVVM.Annotations;
using System.Runtime.CompilerServices;
using CNP_MVVM.Utilities;
using CNP_MVVM.Model;
using System.Collections.ObjectModel;

namespace CNP_MVVM.ViewModel
{
    public class CustomDateViewModel : INotifyPropertyChanged
    {
        public CustomDateViewModel()
        {
           // CustomDate = new CustomDate();
        }

        private CustomDate _customDate;

        public CustomDate CustomDate
        {
            get { return _customDate; }
            set
            { 
                _customDate = value;
                OnPropertyChanged(nameof(CustomDate));
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