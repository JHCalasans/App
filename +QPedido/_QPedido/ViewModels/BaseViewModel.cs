using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using _QPedido.Models;

namespace _QPedido.ViewModels
{
    public class BaseViewModel : BindableBase
    {

        public static Usuario Usuario{ get; set; }

        public static string Servidor
        {
            get
            {
                return "http://www.idotecnologia.com.br/";
            }
        }
    }
}
