using CultuBotApp.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CultuBotApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnHistoria.Clicked += BtnHistoria_Clicked;
            NavigationPage.SetHasNavigationBar(this, false);
            btnBailar.Clicked += BtnBailar_Clicked;
        }

        private void BtnBailar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PageBaile());
        }

        private void BtnHistoria_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PageHistoria());
        }
    }
}
