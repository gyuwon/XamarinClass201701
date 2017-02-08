using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace FormsCrossPlatform
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _email;
        private RelayCommand _addCommand;
        private ObservableCollection<Contact> _contact;

        public MainViewModel()
        {
            _contact = new ObservableCollection<Contact>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }

        public string Email
        {
            get { return _email; }
            set { Set(ref _email, value); }
        }

        public ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand(
                        ExecuteAddCommand,
                        CanExecuteAddCommand);
                }

                return _addCommand;
            }
        }

        public IEnumerable<Contact> Contacts => _contact;

        private void ExecuteAddCommand(object parameter)
        {
            _contact.Add(new Contact
            {
                Name = _name,
                Email = _email
            });
        }

        private bool CanExecuteAddCommand(object parameter)
        {
            return string.IsNullOrWhiteSpace(_name) == false
                && string.IsNullOrWhiteSpace(_email) == false;
        }

        private void Set<T>(
            ref T field,
            T value,
            [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return;
            }

            field = value;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            _addCommand.ChangeCanExecute();
        }
    }
}
