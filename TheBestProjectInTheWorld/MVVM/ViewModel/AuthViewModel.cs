using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using TheBestProjectInTheWorld.Core;
using TheBestProjectInTheWorld.MVVM.Model;

namespace TheBestProjectInTheWorld.MVVM.ViewModel
{
    class AuthViewModel : ObservableObject
    {
        private DispatcherTimer timer = new DispatcherTimer();

        private int seconds = 60;
        private bool canLogin = true;
        private int attempts = 0;
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

        public bool CanLogin
        {
            get => canLogin;
            set
            {
                canLogin = value;
                OnPropertyChanged("CanLogin");
            }
        }

        public AuthViewModel()
        {

            LoginCommand = new RelayCommand(o =>
            {
                //List<Employees> employees = AutoContext.GetContext().Employees.Where(e => e.login == Login).ToList();
                //employees = employees.Where(e => e.password == Password).ToList();
                //if (employees.Count > 0)
                //{
                //    LoginEvent(this, new EventArgs());

                //}
                if (Login == "Log" && Password == "Log")
                {
                    LoginEvent(this, new EventArgs());
                }
                else
                {
                    attempts++;
                    Message = "Неправильно";
                    if (attempts > 3)
                    {
                        CanLogin = false;
                        timer.Interval = new TimeSpan(0,0,1);
                        timer.Tick += Timer_Tick;
                        timer.Start();
                    }
                }
            });
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds--;
            Message = $"Осталось {seconds}";
            if (seconds < 1)
            {
                timer.Stop();
                seconds = 60;
                Message = "";
                CanLogin = true;
            }
        }
    }
}
