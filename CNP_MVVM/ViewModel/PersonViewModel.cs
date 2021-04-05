using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CNP_MVVM.Annotations;
using CNP_MVVM.Command;
using CNP_MVVM.Model;

namespace CNP_MVVM.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        #region Constructor
        public PersonViewModel()
        {
            Person = new Person();
            Persons = new ObservableCollection<Person>();
        }
        #endregion

        #region Properties
        private Person _person;
        public Person Person
        {
            get { return _person; }
            set
            {
                _person = value;
                OnPropertyChanged(nameof(Person));
            }
        }

        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set
            {
                _persons = value;
                OnPropertyChanged("Persons");
            }
        }
        #endregion

        #region AddPersonCommand

        private ICommand _addPersonCommand;
        public ICommand AddPersonCommand
        {
            get
            {
                if (_addPersonCommand == null)// creaza un element nou daca nu exista unul curent
                {
                    _addPersonCommand = new AddPersonCommand(AddPersonExecute, CanAddPersonExecute);
                }
                return _addPersonCommand;
            }
        }

        //private ICommand _deletePersonCommand;

        //public ICommand DeletePersonCommand
        //{
        //    get
        //    {
        //        Persons.Remove(DeletePersonCommand);
        //        return _deletePersonCommand;
        //    }
        //   // set { _deletePersonCommand = value; }
        //}


        private void AddPersonExecute(object parameter)
        {
            Persons.Add(Person);
        }

        private void DeletePerson(object parameter)
        {
            Persons.Remove(Person);
        }

        private bool CanAddPersonExecute(object parameter)
        {
            if (string.IsNullOrEmpty(Person.FirstName) || string.IsNullOrEmpty(Person.LastName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}