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
    }
}
