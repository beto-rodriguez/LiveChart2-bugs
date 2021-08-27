using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LiveChart2Bugs
{
    class RelayCommand : ICommand
    {
        readonly Action _execute = null;
        readonly Func<bool> _canExecute = null;

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return  _canExecute();
        }


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

       public void Execute(object parameter)
        {
            _execute();
        }
    }
}
