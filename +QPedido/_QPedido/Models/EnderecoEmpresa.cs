using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _QPedido.Models
{
    public class EnderecoEmpresa
    {
        public  Int32 codigo { get; set; }

        public Empresa empresa { get; set; }

        public String logradouro { get; set; }

        public String cidade { get; set; }

        public String cep { get; set; }

        public String numero { get; set; }

        public String complemento { get; set; }

        public String bairro { get; set; }

        public String estado { get; set; }

        public bool filial { get; set; }

        public String linkMapa { get; set; }

        public String descricao { get; set; }
    }
}
