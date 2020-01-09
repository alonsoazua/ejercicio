using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio.viewmodel;
using Xamarin.Forms;

namespace Ejercicio
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        AddCarViewModel addCarViewModel;
        public MainPage()
        {
            InitializeComponent();

            addCarViewModel = new AddCarViewModel();

            BindingContext = addCarViewModel;

        }
    }
}
