using System;
using System.ComponentModel;

namespace ObservableObject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var user = new ObservableUser("Tony Stark");

            user.PropertyChanged += OnUserPropertyChanged;

            user.Username = "Ironman";
        }

        private static void OnUserPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Username")
            {
                var user = (ObservableUser)sender;
                Console.WriteLine($"Hello {user.Username}");
            }
        }
    }

    public class ObservableUser : INotifyPropertyChanged
    {
        private string _username;

        public ObservableUser(string username)
        {
            _username = username;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;

                var eventHandler = PropertyChanged;
                if (eventHandler != null)
                    eventHandler.Invoke(this, new PropertyChangedEventArgs("Username"));
            }
        }
    }
}
