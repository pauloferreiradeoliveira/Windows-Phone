using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Agenda
{
   public class Pessoas
    {
        public int id { get; set; }
        public string nome { get; set; }
        public bool sexo { get; set; }
        public DateTimeOffset nacimento { get; set; }
        public string email { get; set; }

        public List<string> lista(List<Pessoas> p)
        {
            List<string> lista = new List<string>();

            foreach (Pessoas s in p)
            {
                lista.Add(s.nome);
            }
            return lista;
        }
      
    }
}
