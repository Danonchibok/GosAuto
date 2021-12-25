using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestProjectInTheWorld.Core;
using TheBestProjectInTheWorld.MVVM.Model;

namespace TheBestProjectInTheWorld.MVVM.ViewModel
{
    class AddNewLicence : ObservableObject
    {
        private DateTime licenceDate;
        private DateTime expireDate;
        private string categories;
        private string licenceSeries;
        private int licenceNumber;
        private Statuses status;

        private string messega;
        public DateTime LicenceDate
        {
            get => licenceDate;
            set
            {
                licenceDate = value;
                OnPropertyChanged("LicenceDate");
            }
        }

        public DateTime ExpireDate
        {
            get => expireDate;
            set
            {
                expireDate = value;
                OnPropertyChanged("ExpireDate");
            }
        }

        public string Categories
        {
            get => categories;
            set
            {
                categories = value;
                OnPropertyChanged("Categories");
            }
        }

        public string LicenceSeries
        {
            get => licenceSeries;
            set
            {
                licenceSeries = value;
                OnPropertyChanged("LicenceSeries");
            }
        }

        public int LicenceNumber
        {
            get => licenceNumber;
            set
            {
                licenceNumber = value;
                OnPropertyChanged("LicenceNumber");
            }
        }

        public Statuses Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        public string Message
        {
            get => messega;
            set
            {
                messega = value;
                OnPropertyChanged("Mesage");
            }
        }
        public List<Statuses> Statuses { get; set; }
        public RelayCommand AddCommand { get; set; }
        public AddNewLicence()
        {
            //Statuses = AutoContext.GetContext().Statuses.ToList();

            AddCommand = new RelayCommand(o =>
            {
                Licences licence = new Licences()
                {
                    licenceDate = LicenceDate,
                    expireDate = ExpireDate,
                    categories = Categories,
                    licenceSeries = licenceSeries,
                    licenceNumber = licenceNumber,
                    Statuses = Status
                };

                Message = DataWorker.AddNewLicence(licence);
            });
        }

        public AddNewLicence(Licences licence)
        {
            Statuses = AutoContext.GetContext().Statuses.ToList();

            LicenceDate = (DateTime)licence.licenceDate;
            LicenceDate = (DateTime)licence.expireDate;
            Categories = licence.categories;
            LicenceSeries = licence.licenceSeries;
            LicenceNumber = (int)licence.licenceNumber;
            Status = licence.Statuses;

            AddCommand = new RelayCommand(o =>
            {
                licence.licenceDate = LicenceDate;
                licence.expireDate = ExpireDate;
                licence.categories = Categories;
                licence.licenceSeries = LicenceSeries;
                licence.licenceNumber = LicenceNumber;
                licence.Statuses = Status;

                Message = DataWorker.EditLicence(licence);
            });
        }
    }
}
