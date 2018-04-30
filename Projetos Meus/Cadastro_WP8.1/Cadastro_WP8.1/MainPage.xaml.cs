using Cadastro_WP8._1.Classe;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Cadastro_WP8._1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double idade = slideridade.Value;
            
            bool sexo = radiomas.IsChecked ?? false;
            string nome = boxnome.Text;
            string email = boxemail.Text;

            if (Validar(nome,email))
            {
                Pessoas p = new Pessoas();
                p.nome = nome;
                p.sexo = sexo;
                p.email = email;
                p.idade = idade;

                Frame.Navigate(typeof(resuldado),p);
            }
            else
            {
                dialago();
            }
        }

        private async void dialago()
        {
            ContentDialog d = new ContentDialog();
            d.Title = "Erro";
            d.Content = "Email ou Nome em Branco";
            d.PrimaryButtonText = "Ok";

            await d.ShowAsync();
            

        }

        private bool Validar(string nome, string email)
        {
            if ((nome == String.Empty) || (email == String.Empty))
            {
                return false;
            }
            else{
                return true;
            }
        }

        private void slideridade_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            txtnum.Text = Convert.ToString(slideridade.Value);
        }

   

        private void limpar()
        {

                boxnome.Text = "";
                boxemail.Text = "";
                slideridade.Value = 0;
        }

        private void btnlimapr_Click(object sender, RoutedEventArgs e)
        {
            limpar();
        }

      

       
    }
}
