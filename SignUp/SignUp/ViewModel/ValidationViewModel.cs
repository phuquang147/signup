using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SignUp.ViewModel
{

    public class ValidationViewModel : BaseViewModel, INotifyDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
            Validate(name);
        }

        private string _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; OnPropertyChanged("FirstName"); } }
        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; OnPropertyChanged("LastName"); } }
        private string _userName;
        public string UserName { get { return _userName; } set { _userName = value; OnPropertyChanged("LastName"); } }
        private string _email;
        public string Email { get { return _email; } set { _email = value; OnPropertyChanged("LastName"); } }
        private string _password;
        public string Password { get { return _password; } set { _password = value; OnPropertyChanged("LastName"); } }
        private string _confirmPassword;
        public string ConfirmPassword { get { return _confirmPassword; } set { _confirmPassword = value; OnPropertyChanged("LastName"); } }
        private string _birthdate;
        public string Birthdate { get { return _birthdate; } set { _birthdate = value; OnPropertyChanged("LastName"); } }

        public ICommand ValidationSignUpCommand { get; set; }

        public ValidationViewModel()
        {
            ValidationSignUpCommand = new RelayCommand<Button>((p) => { return HasErrors ? false : true; }, (p) =>
            {
                Validate(nameof(FirstName));
                Validate(nameof(LastName));
                if (!HasErrors) MessageBox.Show(nameof(FirstName));
            });
        }

        private void Validate(string changedPropertyName)
        {
            switch (changedPropertyName)
            {
                case nameof(FirstName):
                    if (string.IsNullOrWhiteSpace(FirstName))
                    {
                        _ValidationErrorsByProperty["FirstName"] = new List<object> { "Vui lòng nhập họ" };
                        ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(nameof(FirstName)));
                    }
                    else if (_ValidationErrorsByProperty.Remove(nameof(FirstName)))
                    {
                        ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(nameof(FirstName)));
                    }
                    break;
                case nameof(LastName):
                    if (string.IsNullOrWhiteSpace(LastName))
                    {
                        _ValidationErrorsByProperty[nameof(LastName)] = new List<object> { "Vui lòng nhập tên" };
                        ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(nameof(LastName)));
                    }
                    else if (_ValidationErrorsByProperty.Remove(nameof(LastName)))
                    {
                        ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(nameof(LastName)));
                    }
                    break;
            }
        }

        public IEnumerable GetErrors(string propertyName)
        {
            if (_ValidationErrorsByProperty.TryGetValue(propertyName, out List<object> errors))
            {
                return errors;
            }
            return Array.Empty<object>();
        }

      
        private readonly Dictionary<string, List<object>> _ValidationErrorsByProperty = new Dictionary<string, List<object>>();

        public bool HasErrors => _ValidationErrorsByProperty.Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
    }
}
