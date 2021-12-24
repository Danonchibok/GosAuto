using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestProjectInTheWorld.Core;

namespace TheBestProjectInTheWorld.MVVM.ViewModel
{
    class LicencesListViewModel : ObservableObject
    {
        public RelayCommand AddNewLicenceCommand { get; set; }
        public AddNewLicence AddNewLicenceVM { get; set; }

        public event EventHandler DriversCardEvent; //событие для перехода на страницу

        public LicencesListViewModel()
        {
            AddNewLicenceVM = new AddNewLicence();

            AddNewLicenceCommand = new RelayCommand(o => 
            {
                DriversCardEvent(this, new EventArgs()); 
            });

        }

    }
}
