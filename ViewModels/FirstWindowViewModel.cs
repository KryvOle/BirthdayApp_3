using BirthdayApp.Models;
using BirthdayApp.Tools;
using System;
using System.Globalization;
using System.Windows;

namespace BirthdayApp.ViewModels
{
    class FirstWindowViewModel
    {
        private User _user = new User();
        private RelayCommand<object> _continueCommand;

        public string Firstname
        {
            get
            {
                return _user.FirstName;
            }

            set
            {
                _user.FirstName = value;
            }
        }

        public string Lastname
        {
            get
            {
                return _user.LastName;
            }
            set
            {
                _user.LastName = value;
            }
        }

        public string Email
        {
            get
            {
                return _user.Email;
            }
            set
            {
                _user.Email = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return _user.FormalBirthday;
            }
            set
            {
                _user.FormalBirthday = value;
            }
        }

        public RelayCommand<object> ContinueCommand
        {
            get
            {
                return _continueCommand ??= new RelayCommand<object>(_ => Continue(), CanExecute);
            }
        }

        private bool CanExecute(object obj)
        {
            return
                 !string.IsNullOrWhiteSpace(_user.FirstName) &&
                 !string.IsNullOrWhiteSpace(_user.LastName) &&
                 !_user.IsValidEmail() &&
                 !_user.isValid();
                 
        }

        private void Continue()
        {
            User user = new User();

            if (IsBirthday())
            {
                MessageBox.Show($"Happy birthday!!!");
            }

            MessageBox.Show(
            $"Firstname: {_user.FirstName}\n " +
            $"Lastname: {_user.LastName}\n " +
            $"Email: {_user.Email}\n " +
            $"Ages: {_user.Age}\n " +
            $"Zodiac sign: {_user.WestSign}\n " +
            $"Zodiac sign (China): {_user.ChinaSign}\n " +
            $"Is adult: {_user.IsAdult}");
        }

        private bool IsBirthday()
        {
            return _user.todayBirthday();
        }

        
    }
}
