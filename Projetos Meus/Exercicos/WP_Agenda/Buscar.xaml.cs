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
    public sealed partial class Buscar : Page
    {
        List<Pessoas> p = new List<Pessoas>();
        public Buscar()
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
            Pessoas o = new Pessoas();

            cblist.ItemsSource = o.lista(p);
        }

        private void btvoltar_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), p);
        }

        private void cblist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = cblist.SelectedIndex;
            txtnome.Text = p[i].nome;
            txtemail.Text = "Email: " + p[i].email;
            
            txtnasc.Text = string.Format("Data de Nacimento: {0}", p[i].nacimento.ToString("dd/MM/yyyy"));
            if (p[i].sexo)
            {
                txtsexo.Text = String.Format("Sexo: Masculino");
            }
            else
            {
                txtsexo.Text = String.Format("Sexo: Feminino");
            }
            
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
