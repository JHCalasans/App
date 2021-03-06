﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;
using XLabs.Ioc;
using XLabs.Platform.Device;
using _QPedido.Models;

namespace _QPedido.ViewModels
{
    public class InicialViewModel : BaseViewModel, INavigationAware
    {
        private readonly INavigationService _navigationService;

        private readonly IPageDialogService _pageDialogService;

        private ObservableCollection<Usuario> _lista;

        public ObservableCollection<Usuario> Lista
        {
            get { return _lista; }
            set { SetProperty(ref _lista, value); }
        }
        

        public bool IsAndroid { get; set; }

        public int ImgSize { get; set; }

        public DelegateCommand PerfilCommand { get; set; }

        public DelegateCommand ConfiguracoesCommand { get; set; }

        public DelegateCommand BuscarCommand => new DelegateCommand(MudarParaBusca);

        public InicialViewModel(INavigationService navigationService, IPageDialogService  pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
            Lista = new ObservableCollection<Usuario>();
            
            AjusteTamanhoImagens();
            ConfiguracoesCommand = new DelegateCommand(MudarParaConfiguracoes);

        }

        private void AjusteTamanhoImagens()
        {
            var device = Resolver.Resolve<IDevice>();

            if (Device.OS == TargetPlatform.Android)
            {
                ImgSize = Convert.ToInt32(device.Display.Height / 8);
                IsAndroid = true;
            }
            else
            {
                IsAndroid = false;
            }

        }

        private void MudarParaConfiguracoes()
        {
            //var param = new NavigationParameters();
            //// param.Add("usuario", new Usuario(){Nome = "Joao" , Sobrenome = "Teste"});
            //_navigationService.NavigateAsync("Segunda", param);
            _navigationService.NavigateAsync("Configuracoes");
        }

        private void MudarParaBusca()
        {
            _navigationService.NavigateAsync("Buscar");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
         
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }
    }
}
