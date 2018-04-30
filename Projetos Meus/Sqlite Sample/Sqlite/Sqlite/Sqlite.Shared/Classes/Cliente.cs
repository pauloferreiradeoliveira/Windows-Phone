using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sqlite.Classes
{
    [Table("tblCliente")]
    public class Cliente
    {
        [PrimaryKey,AutoIncrement]
        public int Idcliente { get; set; }
        
        [Column("Nome"),NotNull, MaxLength(150)]
        public string Nome { get; set; }

        [NotNull, MaxLength(14), Unique]
        public string CPF { get; set; }
    }
}
