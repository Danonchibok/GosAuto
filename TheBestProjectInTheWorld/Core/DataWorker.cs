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
    }
}
