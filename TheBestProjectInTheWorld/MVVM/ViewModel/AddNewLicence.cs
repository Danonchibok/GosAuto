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
    }
}
