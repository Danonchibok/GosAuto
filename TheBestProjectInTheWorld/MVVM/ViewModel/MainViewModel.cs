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
        public AddDriverViewModel AddDriverVM { get; set; }

        public MainViewModel()
        {
            AuthVM = new AuthViewModel();
            AddDriverVM = new AddDriverViewModel();
            curretnView = AuthVM;

            AuthVM.LoginEvent += AuthVM_LoginEvent;
        }

        private void AuthVM_LoginEvent(object sender, EventArgs e)
        {
            CurrentView = AddDriverVM;
        }
    }
}
