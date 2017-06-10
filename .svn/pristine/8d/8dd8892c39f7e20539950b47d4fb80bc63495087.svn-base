using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using _QPedido.Models;

namespace _QPedido.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        private string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand IrParaSegunda { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            IrParaSegunda = new DelegateCommand(MudarParaSegunda);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }

        private void MudarParaSegunda()
        {
            var param = new NavigationParameters();
            param.Add("usuario", new Usuario(){Nome = "Joao" , Sobrenome = "Teste"});
            _navigationService.NavigateAsync("Segunda", param);
        }
    }
}
