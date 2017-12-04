using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;
using PropertyChanged;
using Xamarin.Forms;
using System.Windows.Input;
using Nearest_Pharmacy.Models;

namespace Nearest_Pharmacy.PageModels
{
    [ImplementPropertyChanged]
    class MenuPageModel : FreshBasePageModel
    {
        public List<MenuModel> menu { get; set; }
        public MenuPageModel()
        {

            menu = new List<MenuModel>
            {
                new MenuModel("На главную"),
                new MenuModel("Профиль"),
                new MenuModel("Заказы"),
                new MenuModel("Информация"),
                new MenuModel("Настройки")
            }; 
        }


        public override void Init(object initData)
        {
            base.Init(initData);
        }

        public ICommand ItemSelect => new Command(async (value) =>
        {
            switch(value)
            {
                case "На главную":
                    FreshPageModelResolver.ResolvePageModel<ProductListPageModel>();
                    break;
                case "Профиль":
                    break;
                case "Заказы":
                    break;
                case "Информация":
                    break;
                case "Настройки":
                    break;
            }
        });

        public ICommand GoLogin => new Command(async =>
        {
            CoreMethods.PushPageModel<LoginPageModel>();
        });
    }
}
