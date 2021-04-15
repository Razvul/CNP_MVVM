using CNP_MVVM.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CNP_MVVM.ViewModel
{
    class MainWindowViewModel:INotifyPropertyChanged
    {
        private string _cautare;

        public string Cautare
        {
            get { return _cautare; }
            set
            {
                _cautare = value;
                OnPropertyChanged(Cautare);
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