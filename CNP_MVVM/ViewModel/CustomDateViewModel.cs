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

        #region Gender
        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                GenerateCNP();
                OnPropertyChanged(nameof(Gender));
            }
        }

        #endregion

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

        private string _year;

        public string Year
        {
            get { return _year; }
            set
            {
                _year = value;
                GenerateCNP();
                OnPropertyChanged(nameof(Year));
            }
        }

        #endregion

        #region Months
        private int _selectedIndexLuni;
        public int SelectedIndexLuni // primeste selected index de la combobox luni
        {
            get
            {
                return _selectedIndexLuni;
            }
            set
            {
                _selectedIndexLuni = value;
                GetDays();
                OnPropertyChanged(nameof(SelectedIndexLuni));
            }
        }
        private string _month;

        public string Month
        {
            get { return _month; }
            set
            {
                _month = value;
                GenerateCNP();
                OnPropertyChanged(nameof(Month));
            }
        }

        #endregion

        #region Days
        private int _selectedIndexZile;
        public int SelectedIndexZile // primeste selected index de la combobox luni
        {
            get
            {
                return _selectedIndexZile;
            }
            set
            {
                _selectedIndexZile = value;
                OnPropertyChanged(nameof(SelectedIndexZile));
            }
        }

        private void GetDays() //primeste numarul maxim de zile dintr-o luna
        {
            var maxDays = Utility.GetMaxDays(_selectedIndexLuni);

            if (_daySource.Count == 0)
            {
                for (int i = 1; i <= maxDays; i++)
                {
                    _daySource.Add(i);
                }
            }
            else
            {
                if (maxDays < _daySource.Count)
                {
                    for (int i = _daySource.Count; i > maxDays; i--)
                    {
                        _daySource.Remove(i);
                    }
                }
                else
                {
                    for (int i = _daySource.Count + 1; i <= maxDays; i++)
                    {
                        _daySource.Add(i);
                    }
                }
            }
            
            // aici nu imi mai trebuie asta pt ca nu maiu fac clear de _daySource
            //if (_indexZiAnterior + 1 > maxDays)
            //{
            //    SelectedIndexZile = maxDays - 1;
            //}
            //else
            //{
            //    SelectedIndexZile = 0;
            //}
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
                OnPropertyChanged(nameof(DaySource));
            }
        }

        private string _day;

        public string Day
        {
            get { return _day; }
            set
            {
                _day = value;
                GenerateCNP();
                OnPropertyChanged(nameof(Day));
            }
        }

        #endregion

        #region Judete
        private string _judet;

        public string Judet
        {
            get { return _judet; }
            set
            {
                _judet = value;
                GenerateCNP();
                OnPropertyChanged(nameof(Judet));
            }
        }
        #endregion

        #region CNP
        private string _cnp;

        public string CNP
        {
            get
            {
                return _cnp;
            }
            set
            {
                _cnp = value;
                OnPropertyChanged(nameof(CNP));
            }
        }

        private void GenerateCNP()
        {
            if (_gender == null || _year == null || _month == null || _day == null || _judet == null)
            {
                return;
            }

            var item = Utility.GetCC
                (Utility.GetSex(_gender, _year),
                Utility.GetYear(_year),
                Utility.GetMonth(_month),
                Utility.GetZi(_day),
                Utility.GetJudet(_judet),
                Utility.GetNNN());

            CNP = Utility.GetCNP(
                Utility.GetSex(_gender, _year),
                Utility.GetYear(_year),
                Utility.GetMonth(_month),
                Utility.GetZi(_day),
                Utility.GetJudet(_judet),
                Utility.GetNNN(),
                item);
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