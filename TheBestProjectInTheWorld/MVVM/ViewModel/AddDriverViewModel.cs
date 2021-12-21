using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestProjectInTheWorld.Core;

namespace TheBestProjectInTheWorld.MVVM.ViewModel
{
    class AddDriverViewModel : ObservableObject
    {
        private string name;
        private string middleName;
        private int passportSerial;
        private int passportNum;
        private int postCode;
        private string address;
        private string company;
        private string jobName;
        private string phone;
        private string email;
        private string photo;
        private string desription;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string MiddleName
        {
            get => middleName;
            set
            {
                middleName = value;
                OnPropertyChanged("MiddleName");
            }
        }
        public int PassportSerial
        {
            get => passportSerial;
            set
            {
                passportSerial = value;
                OnPropertyChanged("PassportSerial");
            }
        }
        public int PassportNum
        {
            get => passportNum;
            set
            {
                passportNum = value;
                OnPropertyChanged("PassportNum");
            }
        }
        public int PostCode
        {
            get => postCode;
            set
            {
                postCode = value;
                OnPropertyChanged("PostCode");
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
        public string Company
        {
            get => company;
            set
            {
                company = value;
                OnPropertyChanged("Company");
            }
        }
        public string JobName
        {
            get => jobName;
            set
            {
                jobName = value;
                OnPropertyChanged("JobName");
            }
        }
        public string Phone
        {
            get => phone;
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }
        public string Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        public string Desription
        {
            get => desription;
            set
            {
                desription = value;
                OnPropertyChanged("Desription");
            }
        }
        public RelayCommand AddCommand { get; set; }

        public AddDriverViewModel()
        {

        }
    }
}
