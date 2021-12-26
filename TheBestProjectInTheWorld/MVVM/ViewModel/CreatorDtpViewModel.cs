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
    class CreatorDtpViewModel : ObservableObject
    {
        private string message;
        private ObservableObject currentView;
        private Classifications classification;
        private string address;
        private DateTime date;
        private int countOfVictims;
        private string imgSchema;
        public Classifications Classification
        {
            get => classification;
            set
            {
                classification = value;
                OnPropertyChanged("Classification");
            }
        }
        public string Address
        {
            get => address;
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }
        public DateTime Date
        {
            get => date;
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }
        public int CountOfVictims
        {
            get => countOfVictims;
            set
            {
                countOfVictims = value;
                OnPropertyChanged("CountOfVictims");
            }
        }
        public string ImgSchema
        {
            get => imgSchema;
            set
            {
                imgSchema = value;
                OnPropertyChanged("ImgSchema");
            }
        }
        public ObservableObject CurrentView
        {
            get => currentView;
            set
            {
                currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }
        public string Message
        {
            get => message;
            set
            {
                OnPropertyChanged("Message");
            }
        }
        public ObservableCollection<Drivers> Drivers { get; set; }
        public ObservableCollection<Cars> Cars { get; set; }
        public AddCarAccidentViewModel AddCarAccidentVM { get; set; }
        public AddDriverAccidentViewModel AddDriverAccidentVM { get; set; }
        public RelayCommand AddDriverCommand { get; set; }
        public RelayCommand AddCarCommand { get; set; }
        public RelayCommand AddDtpCommand { get; set; }

        public CreatorDtpViewModel()
        {
            AddCarAccidentVM = new AddCarAccidentViewModel();
            AddDriverAccidentVM = new AddDriverAccidentViewModel();

            AddDriverCommand = new RelayCommand(o =>
            {
                CurrentView = AddDriverAccidentVM;
            });

            AddCarCommand = new RelayCommand(o =>
            {
                CurrentView = AddCarAccidentVM;
            });

            AddDtpCommand = new RelayCommand(o =>
            {
                if (AddCarAccidentVM.Cars.Count < 1 && AddDriverAccidentVM.Drivers.Count < 1)
                {
                    RoadAccindents accindent = new RoadAccindents()
                    {
                        Classifications = Classification,
                        address = Address,
                        date = Date,
                        CountOfVictims = CountOfVictims,
                        imgSchema = ImgSchema,
                    };
                    Message = DataWorker.AddNewDtp(accindent, AddDriverAccidentVM.Drivers.ToList(), AddCarAccidentVM.Cars.ToList());
                }
                else
                {
                    Message = "Добавь участников";
                }
            });
        }
    }
}
