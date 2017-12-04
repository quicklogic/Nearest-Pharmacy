using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;
using Nearest_Pharmacy.Models;
using Windows.System;
using PropertyChanged;
using Nearest_Pharmacy.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace Nearest_Pharmacy.PageModels
{
    [ImplementPropertyChanged]
    public class RegisterPageModel:FreshBasePageModel
    {
        public IPharmacyService _pharmacyService;
        Models.User user;
        public RegisterPageModel(IPharmacyService pharmacyService)
        {
            _pharmacyService = pharmacyService;
            Registration(user);
        }

        public ICommand GoLogin => new Command(async(value) =>
        {
            user = new Models.User((value) as Models.User);
        });

        public async void Registration(Models.User user)
        {
           
                PharmacyService service = new PharmacyService();
               
                await service.Add(user);
                
  
        }


    }
}
