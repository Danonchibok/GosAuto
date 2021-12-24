using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestProjectInTheWorld.Core;

namespace TheBestProjectInTheWorld.MVVM.ViewModel
{
    class CarsViewModel : ObservableObject
    {
        public RelayCommand CarsVeiwCommand { get; set; }
        public AddNewCar AddNewCarVM { get; set; }

        public event EventHandler CarsViewEventHandler;

        public CarsViewModel()
        {
            CarsVeiwCommand = new RelayCommand(o =>
            {
                AddNewCarVM = new AddNewCar();
                CarsViewEventHandler(this, new EventArgs());
            });
        }
    }
}
