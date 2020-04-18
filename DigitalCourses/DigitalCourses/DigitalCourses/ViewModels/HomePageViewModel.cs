using DigitalCourses.Models;
using DigitalCourses.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DigitalCourses.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public TargetModel Development { get; set; }
        public TargetModel Design { get; set; }
        public TargetModel Marketing { get; set; }
        public TargetModel Photography { get; set; }

        public ICommand GoToMarketingPage { get; set; }

        public HomePageViewModel()
        {
            Development = new TargetModel();
            Design = new TargetModel();
            Marketing = new TargetModel();
            Photography = new TargetModel();

            Development.ImageModel = "development.png";
            Development.FirstText = "Development";
            Development.SecondText = "19 Courses";

            Design.ImageModel = "design.png";
            Design.FirstText = "Design";
            Design.SecondText = "15 Courses";

            Marketing.ImageModel = "marketing.png";
            Marketing.FirstText = "Marketing";
            Marketing.SecondText = "11 Courses";

            Photography.ImageModel = "photography.png";
            Photography.FirstText = "Photography";
            Photography.SecondText = "10 Courses";

            GoToMarketingPage = new Command(async() =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new MarketingPage());
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
