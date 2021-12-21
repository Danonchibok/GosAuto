using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestProjectInTheWorld.Core;
using TheBestProjectInTheWorld.MVVM.Model;

namespace TheBestProjectInTheWorld.MVVM.ViewModel
{
    class AuthViewModel : ObservableObject
    {
        private string login;
        private string password;
        private string message;
        public event EventHandler LoginEvent;
        public RelayCommand LoginCommand { get; set; }
        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public string Message
        {
            get => message;
            set
            {
                message = value;
                OnPropertyChanged("Message");
            }
        }

        public AuthViewModel()
        {
            LoginCommand = new RelayCommand(o =>
            {
                List<Employees> employees = AutoContext.GetContext().Employees.Where(e => e.login == Login).ToList();
                employees = employees.Where(e => e.password == Password).ToList();
                if (employees.Count > 0)
                {
                    LoginEvent(this, new EventArgs());

                }
                else
                {
                    Message = "Неправильно";
                }
            });
        }
    }
}
