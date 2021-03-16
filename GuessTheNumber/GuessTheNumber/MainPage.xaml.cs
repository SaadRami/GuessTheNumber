using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GuessTheNumber
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void onGoBtnClicked(object sender, EventArgs e)
        {
            GuessLogic();

        }

        private void OnEnterPressed(object sender, EventArgs e)
        {
            GuessLogic();
        }

        private void GuessLogic()
        {
            int RandomNumber = new Random().Next(1, 100);

            String Output = "";
            int NumberValue = int.Parse(number.Text);

            if (NumberValue < 1 || NumberValue > 100)
            {
                Output = "Nombre Invalide";
            }
            else
            {
                if (NumberValue < RandomNumber)
                {
                    Output = "Nombre très bas";
                }
                else if (NumberValue > RandomNumber)
                {
                    Output = "Nombre trop élevé";
                }
                else if (NumberValue == RandomNumber)
                {
                    Output = "Bien joué !";
                }
            }

            DisplayAlert("GuessIt!", Output, "Rejouer");
        }
    }
}
