using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestProjectInTheWorld.Core;
using TheBestProjectInTheWorld.MVVM.Model;

namespace TheBestProjectInTheWorld.MVVM.ViewModel
{
    class DriversListViewModel : ObservableObject
    {
        private Drivers currentDriver;
        public ObservableCollection<Drivers> Drivers { get; set; }
        public RelayCommand AddDriverCommand { get; set; }
        public AddDriverViewModel AddDriverVM { get; set; }
        public event EventHandler AddDriverEvent;
        public Drivers CurrentDriver
        {
            get => currentDriver;
            set
            {
                currentDriver = value;
                ChangeDriver(CurrentDriver);
                OnPropertyChanged("CurrentDriver");
            }
        }
        public RelayCommand addNewDriversCommand { get; set; }
       
        public DriversListViewModel()
        {
            addNewDriversCommand = new RelayCommand(o =>
            {
                AddDriverVM = new AddDriverViewModel();
                AddDriverEvent(this, new EventArgs());
            });

            //Drivers = new ObservableCollection<Drivers>(AutoContext.GetContext().Drivers.ToList());
        }

        private void ChangeDriver(Drivers driver)
        {
            AddDriverVM = new AddDriverViewModel(driver);
            AddDriverEvent(this, new EventArgs());
        }
    }
}
