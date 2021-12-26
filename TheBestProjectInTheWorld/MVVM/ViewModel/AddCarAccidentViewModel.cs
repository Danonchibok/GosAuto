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
    class AddCarAccidentViewModel : ObservableObject
    {
        private string vin;
        public string Vin
        {
            get => vin;
            set
            {
                vin = value;
                OnPropertyChanged("Vin");
            }
        }
        public ObservableCollection<CarsAccindent> Cars { get; set; }

        public RelayCommand AddCommand { get; set; }

        public AddCarAccidentViewModel()
        {
            Cars = new ObservableCollection<CarsAccindent>();
            AddCommand = new RelayCommand(o =>
            {
                Cars car = AutoContext.GetContext().Cars.Where(c => c.VIN == Vin).FirstOrDefault();
                CarsAccindent carsAccindent = new CarsAccindent()
                {
                    Cars = car,
                };
                Cars.Add(carsAccindent);
            });
        }
    }
}
