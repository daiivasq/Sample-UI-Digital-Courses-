using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigitalCourses.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TargetsViewPage : ContentView
    {
        public static readonly BindableProperty ImageModelProperty = BindableProperty.Create(nameof(ImageModel), typeof(ImageSource), typeof(TargetsViewPage), default(ImageSource));
        public ImageSource ImageModel
        {
            get => (ImageSource)GetValue(TargetsViewPage.ImageModelProperty);
            set => SetValue(TargetsViewPage.ImageModelProperty, value);
        }

        public static readonly BindableProperty FirstTextProperty = BindableProperty.Create(nameof(FirstText), typeof(string), typeof(TargetsViewPage), String.Empty);
       public string FirstText
        {
            get => (string)GetValue(TargetsViewPage.FirstTextProperty);
            set => SetValue(TargetsViewPage.FirstTextProperty, value);
        }
        public static readonly BindableProperty SecondTextProperty = BindableProperty.Create(nameof(SecondText), typeof(string), typeof(TargetsViewPage), String.Empty);
        public string SecondText
        {
            get => (string)GetValue(TargetsViewPage.SecondTextProperty);
            set => SetValue(TargetsViewPage.SecondTextProperty, value);
        }
        public TargetsViewPage()
        {
            InitializeComponent();
        }
    }
}