using System;
using System.Windows.Input;

namespace FormsCrossPlatform
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public RelayCommand(Action<object> execute)
        {
            _execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (CanExecute(parameter))
            {
                _execute.Invoke(parameter);
            }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        public void ChangeCanExecute()
            => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
