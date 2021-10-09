using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio09
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>{await Navigation.PushAsync(new ExplicitDemo());};
            Item2.Clicked += async (sender, e) =>{await Navigation.PushAsync(new ExplicitControlDemo());};
            Item3.Clicked += async (sender, e) =>{await Navigation.PushAsync(new ImplicitDemo());};
            Item4.Clicked += async (sender, e) =>{await Navigation.PushAsync(new ImplicitControlDemo());};
            Item5.Clicked += async (sender, e) =>{await Navigation.PushAsync(new GlobalDemo());};
            Item6.Clicked += async (sender, e) =>{await Navigation.PushAsync(new InheritanceDemo());};
            Item7.Clicked += async (sender, e) =>{await Navigation.PushAsync(new DynamicDemo());};
            Item8.Clicked += async (sender, e) =>{await Navigation.PushAsync(new ClassDemo());};
            Item9.Clicked += async (sender, e) =>{await Navigation.PushAsync(new EjemploCSS());};
        }
    }
}
