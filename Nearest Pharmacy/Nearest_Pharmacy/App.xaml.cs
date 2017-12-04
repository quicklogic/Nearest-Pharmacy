using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreshMvvm;

using Xamarin.Forms;
using Nearest_Pharmacy.PageModels;
using Nearest_Pharmacy.Models;

namespace Nearest_Pharmacy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FreshIOC.Container.Register<IPharmacyService, PharmacyService>();

            var masterDetailsMultiple = new MasterDetailPage(); 
            var contactListPage = FreshPageModelResolver.ResolvePageModel<MenuPageModel>();
            contactListPage.Title = "Меню";
            var masterPage = new FreshNavigationContainer(contactListPage, "MasterPage");
            masterPage.Title = "Menu";
            masterDetailsMultiple.Master = masterPage;
            var quoteListPage = FreshPageModelResolver.ResolvePageModel<ProductListPageModel>();
            quoteListPage.Title = "Товары:";
            var detailPage = new FreshNavigationContainer(quoteListPage, "DetailPage");
            masterDetailsMultiple.Detail = detailPage; 
            MainPage = masterDetailsMultiple;
        }

       

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
