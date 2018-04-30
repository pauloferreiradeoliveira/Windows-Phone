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
    public sealed partial class BlankPage1 : Page
    {
        Conta c = new Conta();
        public BlankPage1()
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
        }

        private void btnDepositar_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                double p = double.Parse(cxvalor.Text);
                c.Valor = contac.deposito(c, p);
                
                ConCon();
                
            }
            catch (Exception ex)
            {


                ConCon(ex);
            }
            


        }

        private static async void ConCon(Exception ex)
        {
            ContentDialog d = new ContentDialog();
            d.Title = "Erro";
            d.Content = Convert.ToString(ex);
            d.PrimaryButtonText = "OK";
            d.Background = new SolidColorBrush(Windows.UI.Colors.Red);

            await d.ShowAsync();
        }
       
   

        
        private async void ConCon()
        {

            ContentDialog d = new ContentDialog();
            d.Title = "Deposito";
            d.Content="Efetuado com Sucesso";
            d.PrimaryButtonText = "OK";
           

            await d.ShowAsync();
        }

        private void btnVoltat_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), c);
        }

            
        
        
    }
}
