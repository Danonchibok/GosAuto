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
        public Drivers CurrentDriver
        {
            get => currentDriver;
            set
            {
                currentDriver = value;
                OnPropertyChanged("CurrentDriver");
            }
        }

        public DriversListViewModel()
        {
            //Drivers = new ObservableCollection<Drivers>(AutoContext.GetContext().Drivers.ToList());
        }

    }
}
