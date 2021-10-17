using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppD2S2VGuaray
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                string res = "";
                double notaP1 = Convert.ToDouble(txtValor1.Text);
                double notaEx1 = Convert.ToDouble(txtExamen1.Text);

                double notaP2 = Convert.ToDouble(txtValor2.Text);
                double notaEx2 = Convert.ToDouble(txtExamen2.Text);

                if (notaP1 < 1 || notaP2 < 1 || notaEx1 < 1 || notaEx2 < 1)
                {
                    DisplayAlert("Error", "Las notas deben ser mayores a 1", "Ok");
                }
                else if (notaP1 > 10 || notaP2 > 10 || notaEx1 > 10 || notaEx2 > 10)
                {
                    DisplayAlert("Error", "Nota permitido, máximo 10", "Ok");
                }
                else
                {
                    double promedio = ((notaP1 * 0.3) + (notaEx1 * 0.2)) + ((notaP2 * 0.3) + (notaEx2 * 0.2));

                    if (promedio >= 7)
                    {

                        res = "Aprobado ";
                    }
                    else if (promedio >= 5 && promedio <= 6.9)
                    {

                        res = "Complementario ";
                    }
                    else
                    {
                        res = "Reprobado ";
                    }

                    txtPromedio.Text = res + Convert.ToString(promedio);
                }
            }catch(Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Ok");
            }

        }
    }
}
