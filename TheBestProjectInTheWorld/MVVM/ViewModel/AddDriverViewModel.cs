using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using TheBestProjectInTheWorld.Core;
using TheBestProjectInTheWorld.MVVM.Model;

namespace TheBestProjectInTheWorld.MVVM.ViewModel
{
    class AddDriverViewModel : ObservableObject
    {
        private const string imgPath = "/Images/Drivers/";
        private string message;
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
        public string Photo
        {
            get => photo;
            set
            {
                photo = value;
                OnPropertyChanged("Photo");
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
        public RelayCommand AddCommand { get; set; }
        public RelayCommand LoadImgCommand { get; set; }
   
        public AddDriverViewModel()
        {
            LoadImgCommand = new RelayCommand(o =>
            {
                string fileName = LoadImage(AutoContext.GetContext().Drivers.Count() + 1 + ".png");
                Photo = imgPath + fileName;
            });

            AddCommand = new RelayCommand(o =>
            {
                Drivers driver = new Drivers()
                {
                    name = Name,
                    middlename = MiddleName,
                    passportSerial = PassportSerial,
                    passportNumber = PassportNum,
                    postcode = PostCode,
                    address = Address,
                    phone = Phone,
                    email = Email,
                };

                Jobs job = new Jobs()
                {
                    jobname = JobName
                };

                Companies company = new Companies()
                {
                    company = Company
                };

                Message = DataWorker.AddNewDriver(driver, company, job);
            });
        }

        public AddDriverViewModel(Drivers driver)
        {
            Name = driver.name;
            MiddleName = driver.middlename;
            PassportSerial = (int)driver.passportSerial;
            PassportNum = (int)driver.passportNumber;
            PostCode = (int)driver.postcode;
            Address = driver.address;
            Phone = driver.phone;
            Email = driver.email;

            Photo = imgPath + driver.photo;
            AddCommand = new RelayCommand(o => 
            {
                Message = DataWorker.EditDriver(driver, Name, MiddleName, PassportSerial, PassportNum, PostCode, Address, Phone, Email);
            });
        }

        private string LoadImage(string name)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png)|*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage(new Uri(openFileDialog.FileName));
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(image));

                using (FileStream file = new FileStream(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + 
                    imgPath + name, FileMode.CreateNew))
                {
                    encoder.Save(file);
                }
            }
            return name;
        }
    }
}
