using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _QPedido.Models
{
    public class Usuario
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public byte[] ImgUsuario { get; set; }

        public  DateTime DataCriacao { get; set; }

        public DateTime DataNascimento { get; set; }

        public Boolean Ativo { get; set; }

        public string Cpf { get; set; }
    }
}
