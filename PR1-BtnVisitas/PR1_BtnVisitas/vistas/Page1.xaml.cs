using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PR1_BtnVisitas.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {

        //contador
        private int contador = 0;
        public Page1()
        {
            InitializeComponent();
            //onClicked action
            btnPressed.Clicked += (sender, args) => {
                onBtnIncrementPressed();
            };
        }

        private void onBtnIncrementPressed()
        {
            contador += 1;
            //change label value
            if(contador == 1)
                lblCounter.Text = String.Format("Se ha pulsado el botón {0} vez",contador);
            else
                lblCounter.Text = String.Format("Se ha pulsado el botón {0} veces", contador);
        }
    }
}