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

            int sec = Serializer.GetTimeInSeconds();
            if (sec != 60)
            {
                SetLoginFalse(sec);
            }

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
                        SetLoginFalse(60);
                    }
                }
            });

            App.Current.Exit += Current_Exit;
            timer.Tick += Timer_Tick;

        }

        private void Current_Exit(object sender, System.Windows.ExitEventArgs e)
        {
            Serializer.SetTimeInSeconds(seconds);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds--;
            Message = $"Осталось {seconds}";
            if (seconds < 1)
            {
                SetLoginTrue();
            }
        }

        private void SetLoginTrue()
        {
            
            timer.Stop();
            seconds = 60;
            Message = "";
            CanLogin = true;
            Serializer.SetTimeInSeconds(60);
        }

        private void SetLoginFalse(int waitTime)
        {
            seconds = waitTime;
            CanLogin = false;
            timer.Interval = new TimeSpan(0, 0, 1);

            timer.Start();
        }
    }
}
