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

        #region Years
        private void GetYear()
        {
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                _yearSource.Add(i);
            }
        }

        private ObservableCollection<int> _yearSource;

        public ObservableCollection<int> YearSource
        {
            get
            {
                if(_yearSource==null)
                {
                    _yearSource = new ObservableCollection<int>();
                    GetYear();
                }
                return _yearSource;
            }
            set
            {
                _yearSource = value;
                OnPropertyChanged(nameof(YearSource));
            }
        }
        #endregion

        #region Days
        private int _selectedItemLuni;
        public int SelectedItemLuni // primeste selected index de la combobox luni
        {
            get
            {
                return _selectedItemLuni;
            }
            set
            {
                _selectedItemLuni = value;
                GetDays();
            }
        }

        private int GetMaxDays(int selectedIndex) // primeste ca argument SelectedItemLuni
        {
            switch (selectedIndex)
            {
                case 1: return 29;
                case 3:
                case 5:
                case 8:
                case 10: return 30;
                default: return 31;
            }
        } // returneaza numarul maxim de zile dintr-o luna

        private void GetDays() //primeste numarul maxim de zile dintr-o luna
        {
            var maxDays = GetMaxDays(_selectedItemLuni);
            _daySource.Clear();
            for (int i = 1; i <= maxDays; i++)
            {
                _daySource.Add(i);
            }
        } //si umple lista _daySource cu numere de la 1 la GetMaxDays(SelectedItemLuni)

        private ObservableCollection<int> _daySource;

        public ObservableCollection<int> DaySource
        {
            get
            {
                if (_daySource == null)//umple lista daca este goala
                {
                    _daySource = new ObservableCollection<int>();
                    GetDays();
                }
                return _daySource;
            }
            set
            {
                _daySource = value;
                OnPropertyChanged(nameof(_daySource));
            }
        }
        #endregion

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