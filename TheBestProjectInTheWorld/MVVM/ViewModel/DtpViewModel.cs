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

    class DtpViewModel : ObservableObject
    {

        public RelayCommand DtpCreatorCommand { get; set; }
        public CreatorDtpViewModel CreatorDtpVM { get; set; }
        public event EventHandler DtpListEventHandler;
        public ObservableCollection <RoadAccindents> RoadAccindents { get; set; }

        public DtpViewModel()
        {
            RoadAccindents = new ObservableCollection<RoadAccindents>(AutoContext.GetContext().RoadAccindents.ToList());
            
            DtpCreatorCommand = new RelayCommand(o =>
            {
                CreatorDtpVM = new CreatorDtpViewModel();
                DtpListEventHandler(this, new EventArgs());
            });
        }
        
    }
}
