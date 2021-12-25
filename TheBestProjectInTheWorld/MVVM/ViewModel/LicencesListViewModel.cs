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
    class LicencesListViewModel : ObservableObject
    {
        
        private Licences currentLicences;
        public ObservableCollection<Licences> Licences { get; set; }
        public RelayCommand AddNewLicenceCommand { get; set; }
        public AddNewLicence AddNewLicenceVM { get; set; }
        public Licences CurrentLicences
        {
            get => currentLicences;
            set
            {
                currentLicences = value;
                ChangeLicence(CurrentLicences);
                OnPropertyChanged("CurrentLicences");
            }
        }

        public event EventHandler DriversCardEvent; //событие для перехода на страницу

        public LicencesListViewModel()
        {
            //Licences = new ObservableCollection<Licences>(AutoContext.GetContext().Licences.ToList());
            AddNewLicenceCommand = new RelayCommand(o =>
            {
                AddNewLicenceVM = new AddNewLicence();
                DriversCardEvent(this, new EventArgs());
            });

        }

        private void ChangeLicence(Licences licence)
        {
            AddNewLicenceVM = new AddNewLicence(licence);
            DriversCardEvent(this, new EventArgs());
        }

    }
}
