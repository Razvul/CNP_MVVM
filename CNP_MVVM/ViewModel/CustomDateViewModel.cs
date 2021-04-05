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

        public ObservableCollection<Enums.Luni> LuniSource { get; set; } =
            new ObservableCollection<Enums.Luni>
            {
                Enums.Luni.Ianuarie,
                Enums.Luni.Februarie,
                Enums.Luni.Martie,
                Enums.Luni.Aprilie,
                Enums.Luni.Mai,
                Enums.Luni.Iunie,
                Enums.Luni.Iulie,
                Enums.Luni.August,
                Enums.Luni.Septembrie,
                Enums.Luni.Octombrie,
                Enums.Luni.Noiembrie,
                Enums.Luni.Decembrie
            };

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
