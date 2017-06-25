using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _QPedido.Models
{
    public class Empresa
    {

        public Int32 codigo { get; set; }

        public String nome { get; set; }

        public String cnpj { get; set; }

        public String telefone { get; set; }

        public DateTime dataCriacao { get; set; }

        public bool ativo { get; set; }

        public DateTime dataDesativacao { get; set; }
    }
}
