using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace WP_Conta.Classes
{
    class contac
    {
        public static double deposito(Conta p, double num)
        {
            return p.Valor + num;
        }
        public static double SaqueP(Conta p, double num)
        {
            if (p.Valor >= num)
            {
                return p.Valor - num;
            }
            else
            {
                return p.Valor;
            }
        }
     
    }
}
