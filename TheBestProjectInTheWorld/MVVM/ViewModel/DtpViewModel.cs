using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestProjectInTheWorld.Core;

namespace TheBestProjectInTheWorld.MVVM.ViewModel
{
    class DtpViewModel : ObservableObject
    {
        public RelayCommand DtpCreatorCommand { get; set; }

        public CreatorDtpViewModel CreatorDtpVM { get; set; }

        public event EventHandler DtpListEventHandler;
        public DtpViewModel()
        {
            DtpCreatorCommand = new RelayCommand(o =>
            {
                CreatorDtpVM = new CreatorDtpViewModel();
                DtpListEventHandler(this, new EventArgs());
            });
        }
    }
}
