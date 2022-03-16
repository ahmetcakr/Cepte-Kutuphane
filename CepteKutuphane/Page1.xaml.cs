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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        int renkgiris = 0;
        int renkekle = 0;
        int renkkutup = 0;
        int renkhakkim = 0;

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (renkgiris == 0)
            {
                button_giris.BackgroundColor = Color.CornflowerBlue;
                button_giris.TextColor = Color.White;


                frame_giris.BackgroundColor = Color.CornflowerBlue;
                button_giris.ImageSource = "giris5b.png";

                renkgiris = 1;
            }

            else if (renkgiris == 1)
            {
                button_giris.BackgroundColor = Color.White;
                button_giris.TextColor = Color.CornflowerBlue;

                frame_giris.BackgroundColor = Color.White;
                button_giris.ImageSource = "giris5.png";

                renkgiris = 0;
            }
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (renkekle == 0)
            {
                button_ekle.BackgroundColor = Color.CornflowerBlue;
                button_ekle.TextColor = Color.White;


                frame_ekle.BackgroundColor = Color.CornflowerBlue;
                button_ekle.ImageSource = "ekleb.png";

                renkekle = 1;
            }

            else if (renkekle == 1)
            {
                button_ekle.BackgroundColor = Color.White;
                button_ekle.TextColor = Color.CornflowerBlue;

                frame_ekle.BackgroundColor = Color.White;
                button_ekle.ImageSource = "ekle.png";

                renkekle = 0;
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            if (renkkutup == 0)
            {
                button_kutup.BackgroundColor = Color.CornflowerBlue;
                button_kutup.TextColor = Color.White;

                frame_kutup.BackgroundColor = Color.CornflowerBlue;
                button_kutup.ImageSource = "kutupb.png";

                renkkutup = 1;
            }

            else if (renkkutup == 1)
            {
                button_kutup.BackgroundColor = Color.White;
                button_kutup.TextColor = Color.CornflowerBlue;

                frame_kutup.BackgroundColor = Color.White;
                button_kutup.ImageSource = "kutup.png";

                renkkutup = 0;
            }
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            if (renkhakkim == 0)
            {
                button_hakkim.BackgroundColor = Color.CornflowerBlue;
                button_hakkim.TextColor = Color.White;

                frame_hakkim.BackgroundColor = Color.CornflowerBlue;
                button_hakkim.ImageSource = "hakkimb.png";

                renkhakkim = 1;
            }

            else if (renkhakkim == 1)
            {
                button_hakkim.BackgroundColor = Color.White;
                button_hakkim.TextColor = Color.CornflowerBlue;

                frame_hakkim.BackgroundColor = Color.White;
                button_hakkim.ImageSource = "hakkim.png";

                renkhakkim = 0;
            }
        }
    }
}