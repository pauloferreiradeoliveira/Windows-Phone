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
using WP_Conta.Classes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace WP_Conta
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Sacar : Page
    {
        Conta c = new Conta();
        public Sacar()
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
            c = e.Parameter as Conta;
            sliderValor.Maximum = c.Valor;
        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            txtvalor.Text = String.Format("{0:0.00}",sliderValor.Value);
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), c);
        }

        private void btnSaque_Click(object sender, RoutedEventArgs e)
        {
            c.Valor = contac.SaqueP(c,sliderValor.Value);
            ConCon();
            sliderValor.Maximum = c.Valor;
        }

        private async void ConCon()
        {

            ContentDialog d = new ContentDialog();
            d.Title = "Saque";
            d.Content = "Efetuado com Sucesso";
            d.PrimaryButtonText = "OK";

            await d.ShowAsync();
        }
    }
}
