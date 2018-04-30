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
    public sealed partial class Imprimir : Page
    {
        List<Pessoas> p = new List<Pessoas>();
        public Imprimir()
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
            
          
           

           
            
            foreach (Pessoas n in p)
            {
                TextBlock a1 = new TextBlock();
                a1.FontSize = 25;
                a1.TextAlignment = TextAlignment.Center;

                TextBlock a2 = new TextBlock();
                a2.FontSize = 20;
                TextBlock a5 = new TextBlock();
                a5.FontSize = 20;

                TextBlock a3 = new TextBlock();
                a5.Text = "______________________________________________________________________________________";
                a3.FontSize = 20;

                TextBlock a4 = new TextBlock();
                a4.FontSize = 20;

                

                int c = 0;
                a1.Text = n.nome;
                a1.Name = string.Format("TxtNome{0}", c);
                stck.Children.Add(a1);
         
                a2.Text = string.Format("Email: {0}", n.email);
                stck.Children.Add(a2);

                a3.Text = string.Format("Data de Nacimento: {0}", n.nacimento.ToString("dd/MM/yyyy"));
                stck.Children.Add(a3);

                if (n.sexo)
                {
                    a4.Text = String.Format("Sexo: Masculino");
                }
                else
                {
                    a4.Text = String.Format("Sexo: Feminino");
                }
                stck.Children.Add(a4);
                stck.Children.Add(a5);

                
            }
            
           

        }

        private void btnvoltar_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), p);
            
        }
    }
}
