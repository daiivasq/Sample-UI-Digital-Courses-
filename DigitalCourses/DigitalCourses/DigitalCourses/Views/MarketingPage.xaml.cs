using DigitalCourses.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigitalCourses.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarketingPage : ContentPage
    {
        public MarketingPage()
        {
            InitializeComponent();
            BindingContext = new MarketingPageViewModel();
        }
    }
}