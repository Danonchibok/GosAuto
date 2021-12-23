using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestProjectInTheWorld.Core;

namespace TheBestProjectInTheWorld.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        private ObservableObject curretnView;

        private bool isLogged;//pole
        public bool IsLogged //cvoystvo
        {
            get => isLogged;
            set
            {
                isLogged = value;
                OnPropertyChanged("IsLogged");
            }
        }
        public ObservableObject CurrentView
        {
            get => curretnView;
            set
            {
                curretnView = value;
                OnPropertyChanged("CurrentView");
            }
        }
        public AuthViewModel AuthVM { get; set; }
        public RelayCommand ExitCommand { get; set; }
        public AddDriverViewModel AddDriverVM { get; set; }

        public MainViewModel()
        {
            IsLogged = false; //Потом сменить false
            AuthVM = new AuthViewModel();
            AddDriverVM = new AddDriverViewModel();
            curretnView = AuthVM;

            AuthVM.LoginEvent += AuthVM_LoginEvent;

            ExitCommand = new RelayCommand(o =>
            {
                CurrentView = AuthVM;
                IsLogged = false;
            });
        }

        private void AuthVM_LoginEvent(object sender, EventArgs e)
        {
            CurrentView = AddDriverVM;
        }
    }
}
