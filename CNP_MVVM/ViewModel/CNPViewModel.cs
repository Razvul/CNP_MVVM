using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CNP_MVVM.Annotations;
using CNP_MVVM.Model;
using CNP_MVVM.Utilities;

namespace CNP_MVVM.ViewModel
{
    public class CNPViewModel : INotifyPropertyChanged
    {
        #region Constructor
        public CNPViewModel()
        {
            CNP = new CNP();
        }
        #endregion

        private CNP _cnp;
        public CNP CNP
        {
            get { return _cnp; }
            set
            {
                _cnp = value;
                OnPropertyChanged(nameof(CNP));// modificarile se fac automat
            }
        }

        public ObservableCollection<Enums.Gender> GenderSource { get; set; } =
            new ObservableCollection<Enums.Gender>
            {
                Enums.Gender.Masculin,
                Enums.Gender.Feminin
            };


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}