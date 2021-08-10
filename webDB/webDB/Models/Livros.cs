using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webDB.Models
{
    public class Livros : BaseModel
    {

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Autor { get; set; }

        public int QuantidadeDePaginas { get; set; }

        public DateTime DataDeLancamento { get; set; }

    }
}