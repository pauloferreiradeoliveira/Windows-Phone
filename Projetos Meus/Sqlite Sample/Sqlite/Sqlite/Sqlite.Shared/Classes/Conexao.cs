using SQLite; //Importado
using System;
using System.Collections.Generic;
using System.IO; // Importado
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Sqlite.Classes
{
    class Conexao
    {
        
        //Informando o camilho local com o nome banco
        static string nomeBanco = Path.Combine(ApplicationData.Current.LocalFolder.Path, "dbTeste.sqlite");

        private static void CriarBancoDados()
        {
            //Monta a conexão do banco de dados com o arquivo a criado
            using(SQLiteConnection db = new SQLiteConnection(nomeBanco))
            {
                //Criar a Tabela Cliente
                db.CreateTable<Cliente>();
            }
        }

        private static async Task<bool> VerificarBanco(string dbNome)
        {
            bool flgReturn = true;

            try
            {
                await ApplicationData.Current.LocalFolder.GetFileAsync(dbNome);
            }
            catch (Exception)
            {

                flgReturn = false;
            }
            return flgReturn;
        }

        private static void CriarBase()
        {
            bool be = VerificarBanco(nomeBanco).Result;

            if (!be)
            {
                CriarBancoDados();  
            }

        }

        public static SQLiteConnection Conn()
        {
            try
            {
                SQLiteConnection sconn = new SQLiteConnection(nomeBanco);

                CriarBase();

                return sconn;
            }
            catch (Exception)
            {
                
                throw;
            }
         
        }
    }
}
