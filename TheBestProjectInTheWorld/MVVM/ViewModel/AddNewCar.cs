using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestProjectInTheWorld.Core;
using TheBestProjectInTheWorld.MVVM.Model;

namespace TheBestProjectInTheWorld.MVVM.ViewModel
{
    class AddNewCar : ObservableObject
    {
        private string vin;
        private float year;
        private int weight;
        private int color;
        private EngineTypes engine;
        private Manufacturers manufacturer;
        private TypeDrives driveType;
        private Models model;
        private Drivers driver;

        private string message;
        public string Vin
        {
            get => vin;
            set
            {
                vin = value;
                OnPropertyChanged("Vin");
            }
        }
        public float Year
        {
            get => year;
            set
            {
                year = value;
                OnPropertyChanged("Year");
            }
        }
        public int Weight
        {
            get => weight;
            set
            {
                weight = value;
                OnPropertyChanged("Weight");
            }
        }
        public int Color
        {
            get => color;
            set
            {
                color = value;
                OnPropertyChanged("Color");
            }
        }
        public EngineTypes Engine
        {
            get => engine;
            set
            {
                engine = value;
                OnPropertyChanged("Engine");
            }
        }
        public Manufacturers Manufacturer
        {
            get => manufacturer;
            set
            {
                manufacturer = value;
                OnPropertyChanged("Manufacturer");
            }
        }

        public TypeDrives DriveType
        {
            get => driveType;
            set
            {
                driveType = value;
                OnPropertyChanged("DriveType");

            }
        }
        public Models Model
        {
            get => model;
            set
            {
                model = value;
                OnPropertyChanged("Model");
            }
        }

        public Drivers Driver
        {
            get => driver;
            set
            {
                driver = value;
                OnPropertyChanged("Driver");
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

        public List<EngineTypes> EngineTypes { get; set; }
        public List<Manufacturers> Manufacturers { get; set; }
        public List<TypeDrives> TypeDrives { get; set; }
        public List<Models> Models { get; set; }

        public RelayCommand AddCommand { get; set; }

        public AddNewCar()
        {
            InitLists();

            AddCommand = new RelayCommand(o =>
            {
                Cars car = new Cars()
                {
                    VIN = Vin,
                    Year = Year,
                    Weight = Weight,
                    Color = Color,
                    EngineTypes = Engine,
                    Manufacturers = Manufacturer,
                    TypeDrives = DriveType,
                    Models = Model,
                    Drivers = Driver,
                };

                Message = DataWorker.AddNewCar(car);
            });
        }

        public AddNewCar(Cars car)
        {
            InitLists();

            Vin = car.VIN;
            Year = (float)car.Year;
            Weight = (int)car.Weight;
            Color = (int)car.Color;
            Engine = car.EngineTypes;
            Manufacturer = car.Manufacturers;
            DriveType = car.TypeDrives;
            Model = car.Models;
            Driver = car.Drivers;

            AddCommand = new RelayCommand(o =>
            {
                car.VIN = Vin;
                car.Year = Year;
                car.Weight = Weight;
                car.Color = Color;
                car.EngineTypes = Engine;
                car.Manufacturers = Manufacturer;
                car.TypeDrives = DriveType;
                car.Models = Model;
                car.Drivers = Driver;

                AutoContext.GetContext().SaveChanges();
            });
        }

        private void InitLists()
        {

            //Модель двигателя, Производитель, тип привода, модель

            EngineTypes = AutoContext.GetContext().EngineTypes.ToList();
            Manufacturers = AutoContext.GetContext().Manufacturers.ToList();
            TypeDrives = AutoContext.GetContext().TypeDrives.ToList();
            Models = AutoContext.GetContext().Models.ToList();
        }
    }

}
