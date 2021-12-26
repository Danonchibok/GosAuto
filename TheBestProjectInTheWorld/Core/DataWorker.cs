using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestProjectInTheWorld.MVVM.Model;

namespace TheBestProjectInTheWorld.Core
{
    class DataWorker
    {
        public static string AddNewDriver(Drivers driver, Companies company, Jobs job)
        {
            string message = "Добавлено";
            List<Jobs> jobs = AutoContext.GetContext().Jobs.Where(j => j.jobname == job.jobname).ToList();
            List<Companies> companies = AutoContext.GetContext().Companies.Where(j => j.company == company.company).ToList();

            if (jobs.Count > 0)
            {
                job = jobs.FirstOrDefault();
            }
            if (companies.Count > 0)
            {
                company = companies.FirstOrDefault();
            }
            driver.Companies = company;
            driver.Jobs = job;
            AutoContext.GetContext().Drivers.Add(driver);
            return message;
        }

        public static string EditDriver(Drivers driver, string name, string middleName, int passSerial, int passNum, int postCode,
            string addres, string phone, string email)
        {
            string message = "Данные обновлены";
            driver.name = name;
            driver.middlename = middleName;
            driver.passportSerial = passSerial;
            driver.passportNumber = passNum;
            driver.postcode = postCode;
            driver.address = addres;
            driver.phone = phone;
            driver.email = email;
            AutoContext.GetContext().SaveChanges();
            return message;
        }

        public static string AddNewCar(Cars newCar)
        {
            string message = "Добавлено";
            List<Cars> cars = AutoContext.GetContext().Cars.Where(c => c.VIN == newCar.VIN).ToList();
            if (cars.Count > 0)
            {
                message = "Есть такая!";
            }
            else
            {
                AutoContext.GetContext().Cars.Add(newCar);
                AutoContext.GetContext().SaveChanges();
            }
            return message;
        }

        public static string AddNewLicence(Licences licence)
        {
            string message = "Добавлено";
            List<Licences> licences = AutoContext.GetContext().Licences.Where(l => l.licenceNumber == licence.licenceNumber).ToList();
            if (licences.Count > 0)
            {
                message = "Невозможно добавить, такое удостоверение уже есть";
            }
            else
            {
                AutoContext.GetContext().Licences.Add(licence);
                AutoContext.GetContext().SaveChanges();
            }
            return message;
        }

        public static string EditLicence(Licences licence)
        {
            string message = "Данные обновлены";
            Licences oldLicence = AutoContext.GetContext().Licences.Where(l => l.id == licence.id).FirstOrDefault();
           
            if (licence.Statuses.id != oldLicence.Statuses.id)
            {
                ChangedStatusHistory changedStatusHistory = new ChangedStatusHistory()
                {
                    date = DateTime.Now,
                    Licences = licence,
                    Statuses = oldLicence.Statuses,
                    Statuses1 = licence.Statuses,
                    
                };
                AutoContext.GetContext().ChangedStatusHistory.Add(changedStatusHistory);

            }
            AutoContext.GetContext().SaveChanges();
            return message;
        }

        public static string AddNewDtp(RoadAccindents roadAccindent, List<driversAccindet> driversAccindets, List<CarsAccindent> carsAccindents)
        {
            string message = "Добавлено";
            foreach (driversAccindet item in driversAccindets)
            {
                item.RoadAccindents = roadAccindent;
                AutoContext.GetContext().driversAccindet.Add(item);
            }
            foreach (CarsAccindent item in carsAccindents)
            {
                item.RoadAccindents = roadAccindent;
                AutoContext.GetContext().CarsAccindent.Add(item);
            }
            AutoContext.GetContext().RoadAccindents.Add(roadAccindent);
            AutoContext.GetContext().SaveChanges();
            return message;
        }
    }
}
