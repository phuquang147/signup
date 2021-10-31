using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Globalization;

namespace SignUp.ViewModel
{
    

    class SignUpViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public class NotEmptyValidationRule : ValidationRule
        {
            public string Message { get; set; }

            public override ValidationResult Validate(object value, CultureInfo cultureInfo)
            {
                if (string.IsNullOrWhiteSpace(value?.ToString()))
                {
                    return new ValidationResult(false, Message ?? "Vui lòng nhập thông tin");
                }
                return ValidationResult.ValidResult;
            }
        }

        private string _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; OnPropertyChanged("FirstName"); } }
        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; OnPropertyChanged("LastName"); } }

        private ICommand _validationSignUpCommand;
        public ICommand ValidationSignUpCommand 
        {
            get
            {
                if (_validationSignUpCommand == null)
                {
                    _validationSignUpCommand = new RelayCommand<Button>((p) => { return CheckEmpty() ? false : true; }, (p) =>
                    {
                        MessageBox.Show("Hi");
                    });
                }
                //OnPropertyChanged("ValidationSignUpCommand");
                return _validationSignUpCommand;
            }
            set 
            { 
                _validationSignUpCommand = value; 
                OnPropertyChanged("ValidationSignUpCommand"); 
            } 
        }

        public bool CheckEmpty()
        {
            return string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName);
        }

        public SignUpViewModel()
        {
            //ValidationSignUpCommand = new RelayCommand<Button>((p) => { return CheckEmpty() ? false : true; }, (p) =>
            //{
            //    MessageBox.Show("Hi");
            //});
        }
    }
}
