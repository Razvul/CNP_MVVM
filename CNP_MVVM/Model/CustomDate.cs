using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNP_MVVM.Annotations;
using System.Runtime.CompilerServices;
using CNP_MVVM.Utilities;

namespace CNP_MVVM.Model
{
    public class CustomDate : INotifyPropertyChanged
    {
        private Enums.Zi _zi;

        public Enums.Zi Zi
        {
            get { return _zi; }
            set
            {
                _zi = value;
                OnPropertyChanged(nameof(Zi));
            }
        }

        private Enums.Luni _luni;

        public Enums.Luni Luni
        {
            get { return _luni; }
            set
            {
                _luni = value;
                OnPropertyChanged(nameof(Luni));
            }
        }

        private int _an;

        public int An
        {
            get { return _an; }
            set
            {
                _an = value;
                OnPropertyChanged(nameof(An));
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