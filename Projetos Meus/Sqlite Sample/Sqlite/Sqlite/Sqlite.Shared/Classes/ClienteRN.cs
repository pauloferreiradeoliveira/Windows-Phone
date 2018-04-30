using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace Sqlite.Classes
{
    public class ClienteRN
    {
        public List<Cliente> Listar()
        {
            return Conexao.Conn().Table<Cliente>().ToList();

            //return Conexao.Conn().Query<Cliente>("Select * from tblCliente").ToList();
        }

        public List<Cliente> Lista(string nome)
        {
            return Conexao.Conn().Query<Cliente>("Select * from tblCliente WHERE Nome = ?", nome).ToList();
        }

        public List<Cliente> Listar(Expression<Func<Cliente, bool>> filtro)
        {
            return Conexao.Conn().Table<Cliente>().Where(filtro).ToList();

        }

        public int Gravar(Cliente registro){
            return Conexao.Conn().InsertOrReplace(registro);
        }
        
        public int Inserir(List<Cliente> lstRegistro)
        {
            return Conexao.Conn().InsertAll(lstRegistro);
        }
    }
}
