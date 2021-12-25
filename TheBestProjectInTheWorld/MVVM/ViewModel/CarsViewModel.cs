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
    class CarsViewModel : ObservableObject
    {
        private Cars currentCar;

        public event EventHandler CarsViewEventHandler;
        public ObservableCollection<Cars> Cars { get; set; }
        public RelayCommand CarsVeiwCommand { get; set; }
        public AddNewCar AddNewCarVM { get; set; }
        public Cars CurrentCar
        {
            get => currentCar;
            set
            {
                currentCar = value;
                AddNewCarVM = new AddNewCar(CurrentCar);
                CarsViewEventHandler(this, new EventArgs());
                OnPropertyChanged("CurrentCar");
            }
        }

        public CarsViewModel()
        {
           // Cars = new ObservableCollection<Cars>(AutoContext.GetContext().Cars.ToList());
            CarsVeiwCommand = new RelayCommand(o =>
            {
                AddNewCarVM = new AddNewCar();
                CarsViewEventHandler(this, new EventArgs());
            });
        }
    }
}
