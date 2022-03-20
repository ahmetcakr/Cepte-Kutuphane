using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace CepteKutuphane
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class giris : ContentPage
    {
        public giris()
        {
            InitializeComponent();
        }

        public async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new kayit());
        }
    }
}