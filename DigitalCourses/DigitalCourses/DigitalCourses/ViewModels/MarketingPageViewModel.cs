using DigitalCourses.Models;
using DigitalCourses.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DigitalCourses.ViewModels
{
    public class MarketingPageViewModel
    {
        string _imageModel = "play.png";
        public ObservableCollection<TargetModel> CoursesList { get; set; } = new ObservableCollection<TargetModel>();
        public ICommand GoToBack { get; set; }
      
        public MarketingPageViewModel()
        {
            CoursesList.Add(new TargetModel() { ImageModel = _imageModel, FirstText = "Market Research Intro", SecondText = "10.20 Mins" });
            CoursesList.Add(new TargetModel() { ImageModel = _imageModel, FirstText = "How to get responses to your", SecondText = "05.20 Mins" });
            CoursesList.Add(new TargetModel() { ImageModel = _imageModel, FirstText = "How to analyse your survey results", SecondText = "15.20 Mins" });
            CoursesList.Add(new TargetModel() { ImageModel = _imageModel, FirstText = "Why market your business whit", SecondText = "11.20 Mins" });
            CoursesList.Add(new TargetModel() { ImageModel = _imageModel, FirstText = "Collect emails without a website", SecondText = "08.20 Mins" });
            CoursesList.Add(new TargetModel() { ImageModel = "play.png", FirstText = "How to be the best xamarin developer", SecondText = "59.60 Mins" });

            GoToBack = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PopToRootAsync();
            });
        }
      
    }
}
