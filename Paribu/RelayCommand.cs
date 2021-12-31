using System;
using System.Windows.Input;

namespace Paribu
{
    public class RelayCommand : ICommand
    {
        public RelayCommand(Action<object> execute)
        {
            this.execute = execute;
            canExecute = null;
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || CanExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        private readonly Func<object, bool> canExecute;

        private readonly Action<object> execute;
    }
}