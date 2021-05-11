using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CNP_MVVM.Command
{
    class RemovePersonComamand
    {
        private readonly Action<object> _executeAction;
        private readonly Func<object, bool> _canExecute;

        public RemovePersonComamand(Action<object> executeAction, Func<object, bool> canExecute)
        {
            _canExecute = canExecute;
            _executeAction = executeAction;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }
            else
            {
                return _canExecute(parameter);
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }
    }
}