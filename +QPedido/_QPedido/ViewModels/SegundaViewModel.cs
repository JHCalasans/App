using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using _QPedido.Models;

namespace _QPedido.ViewModels
{
    public class SegundaViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        private Usuario _usuario;

        public Usuario Usuario
        {
            get { return _usuario; }
            set { SetProperty(ref _usuario, value); }
        }

        public SegundaViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("usuario"))
                Usuario = (Usuario)parameters["usuario"];
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
