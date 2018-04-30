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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace WP_Agenda
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Cadastro : Page
    {
        List<Pessoas> p = new List<Pessoas>();
        public Cadastro()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            p = e.Parameter as List<Pessoas>;
        }

        private void btnvoltar1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage),p);
        }

        private void btnenviar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (vazio(ctnome.Text,ctemail.Text))
                {
                    Pessoas i = new Pessoas();
                    i.nome = ctnome.Text;
                    i.email = ctemail.Text;
                    i.nacimento = dtnacimento.Date;
                    i.sexo = radiamas.IsChecked ?? true;
                    p.Add(i);
                    ConCon();  
                }
                


            }
            catch (Exception ex)
            {

                ConCon(Convert.ToString(ex));
            }
        }

        private bool vazio(string p1, string p2)
        {
            if (string.IsNullOrEmpty(p1)) 
            {
                ConCon("Nome esta em Branco");
                return false;
            }
            else if (string.IsNullOrEmpty(p2))
            {
                ConCon("Email esta em Branco");
                return false;
            }
            else
            {
                return true;
            }
        }

       

        private async void ConCon(string p)
        {
            ContentDialog d = new ContentDialog();
            d.Title = "Cadastro";
            d.Content = p;
            d.PrimaryButtonText = "OK";




            await d.ShowAsync();
        }


        private async void ConCon()
        {

            ContentDialog d = new ContentDialog();
            d.Title = "Cadastro";
            d.Content = "Efetuado com Sucesso";
            d.PrimaryButtonText = "OK";

            await d.ShowAsync();
        }

        private void btnlimpar_Click(object sender, RoutedEventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            ctemail.Text = "";
            ctnome.Text = "";
        }
    }
}
