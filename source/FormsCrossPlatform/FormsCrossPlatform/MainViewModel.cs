using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FormsCrossPlatform
{
    public class MainViewModel : ObservableObject
    {
        private string _name;
        private string _email;
        private RelayCommand _addCommand;
        private readonly ObservableCollection<Contact> _contact;

        public MainViewModel()
        {
            _name = string.Empty;
            _email = string.Empty;
            _contact = new ObservableCollection<Contact>();
        }

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

            Name = string.Empty;
            Email = string.Empty;
        }

        private bool CanExecuteAddCommand(object parameter)
        {
            return string.IsNullOrWhiteSpace(_name) == false
                && string.IsNullOrWhiteSpace(_email) == false;
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);

            _addCommand?.ChangeCanExecute();
        }
    }
}
