using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CultuBotApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageHistoria : ContentPage
    {
        public PageHistoria()
        {
            InitializeComponent();
            btnGueguense.Clicked += BtnGueguense_Clicked;
            btnGigantona.Clicked += BtnGigantona_Clicked;
        }

        private void BtnGigantona_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PageGigantona());
        }

        private void BtnGueguense_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new PageGueguense());
        }
    }
}