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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WP_Conta
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Conta p = new Conta();
       


        public MainPage()
        {
            this.InitializeComponent();
            p.Valor = 0;


           // Slider saque = BuscarControleFilho<Slider>(HubConta, "slidersaque") as Slider;
            //TextBlock txtsaldo = BuscarControleFilho<TextBlock>(HubConta, "txtSaldo") as TextBlock;
            //saque.Maximum = p.Valor;
            //txtsaldo.Text = String.Format("{0}", p.Valor);
            
         
        }

        private void Sacar_Click(object sender, RoutedEventArgs e)
        {
            Slider saque = BuscarControleFilho<Slider>(HubConta, "slidersaque") as Slider;
            TextBlock txtsaldo = BuscarControleFilho<TextBlock>(HubConta, "txtSaldo") as TextBlock;
            p.Valor = contac.SaqueP(p, saque.Value);
            saque.Maximum = p.Valor;
            txtsaldo.Text = String.Format("{0}", p.Valor);


               
        }

        private DependencyObject BuscarControleFilho<T>(DependencyObject controle, string controleFilho)
        {
            int childNumber = VisualTreeHelper.GetChildrenCount(controle);
            for (int i = 0; i < childNumber; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(controle, i);
                FrameworkElement fe = child as FrameworkElement;
                // Not a framework element or is null
                if (fe == null) return null;

                if (child is T && fe.Name == controleFilho)
                {
                    // Found the control so return
                    return child;
                }
                else
                {
                    // Not found it - search children
                    DependencyObject nextLevel = BuscarControleFilho<T>(child, controleFilho);
                    if (nextLevel != null)
                        return nextLevel;
                }
            }
            return null;
        }

        private void Depositar_Click(object sender, RoutedEventArgs e)
        {
           // p.Valor = 0;

            TextBox deposito = BuscarControleFilho<TextBox>(HubConta, "boxdeposido") as TextBox;
            p.Valor = contac.deposito(p, Convert.ToDouble(deposito.Text));
            Slider saque = BuscarControleFilho<Slider>(HubConta, "slidersaque") as Slider;
            TextBlock txtsaldo = BuscarControleFilho<TextBlock>(HubConta, "txtSaldo") as TextBlock;
            
            saque.Maximum = p.Valor;
            txtsaldo.Text = String.Format("{0}", p.Valor);

        
        }

        private void slidersaque_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider saque = BuscarControleFilho<Slider>(HubConta, "slidersaque") as Slider;
            TextBlock valor = BuscarControleFilho<TextBlock>(HubConta, "txtvalor") as TextBlock;

            valor.Text = String.Format("{0}", saque.Value);
        }
    }

}
