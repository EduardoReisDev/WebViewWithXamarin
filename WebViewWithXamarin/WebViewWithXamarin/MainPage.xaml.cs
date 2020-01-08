using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewWithXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void GoPagina(object sender, EventArgs args)
        {
            Navegador.Source = EnderecoSite.Text;
        }

        public void GoProximo(object sender, EventArgs args)
        {
            if (Navegador.CanGoForward)
            {
                Navegador.GoForward();
            }
        }

        public void GoVoltar(object sender, EventArgs args)
        {
            if (Navegador.CanGoBack)
            {
                Navegador.GoBack();
            }
        }

        public void ActionCarregando(object sender, EventArgs args)
        {
            LblStatus.Text = "Carregando...";
        }

        public void ActionCarregado(object sender, EventArgs args)
        {
            LblStatus.Text = "Carregado!";
        }
    }
}
