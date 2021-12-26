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
    class AddDriverAccidentViewModel : ObservableObject
    {
        private int driverPassNum;
        public int DriverPassNum
        {
            get => driverPassNum;
            set
            {
                driverPassNum = value;
                OnPropertyChanged("DriverPassNum");
            }
        }
        public ObservableCollection<driversAccindet> Drivers { get; set; } 

        public RelayCommand AddCommand { get; set; }

        public AddDriverAccidentViewModel()
        {
            Drivers = new ObservableCollection<driversAccindet>();
            AddCommand = new RelayCommand(o =>
            {
                Drivers driver = AutoContext.GetContext().Drivers.Where(d => d.passportNumber == DriverPassNum).FirstOrDefault();
                driversAccindet accindentdriver = new driversAccindet()
                {
                    Drivers = driver,
                };
                Drivers.Add(accindentdriver);
            });
        }
    }
}
