using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _QPedido.Models
{
    public class Usuario
    {
        public string nome { get; set; }

        public string telefone { get; set; }

        public string email { get; set; }
        
        public byte[] imgUsuario { get; set; }

        public  DateTime dataCriacao { get; set; }

        public DateTime dataNascimento { get; set; }

        public Boolean ativo { get; set; }

        public string senha { get; set; }
    }
}
