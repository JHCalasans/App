using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using Acr.UserDialogs;
using Newtonsoft.Json;
using Prism.Navigation;
using Prism.Services;
using _QPedido.Models;

namespace _QPedido.ViewModels
{
    public class CadastroUsuarioViewModel : BaseViewModel, INavigationAware
    {
        private readonly INavigationService _navigationService;

        private readonly IPageDialogService _pageDialogService;

        private Usuario _usuario;

        public Usuario UsuarioCadastro
        {
            get { return _usuario; }
            set { SetProperty(ref _usuario, value); }
        }
        public DelegateCommand CadastrarCommand { get; set; }

        public CadastroUsuarioViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
            CadastrarCommand = new DelegateCommand(BuscarUsuarios);
             UsuarioCadastro = new Usuario(); 

        }

        private async void BuscarUsuarios()
        {
           
            try
            {
                UserDialogs.Instance.ShowLoading("Carregando", MaskType.Gradient);
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://192.168.0.15:8080/");

                var json = JsonConvert.SerializeObject(UsuarioCadastro);

                var content = new StringContent(json , Encoding.UTF8, "application/json");

                var response = await client.PostAsync("qPedido/ws/usuario", content);

                if (response.IsSuccessStatusCode)
                {

                    await _pageDialogService.DisplayAlertAsync("Aviso", "Gravado com Sucesso", "Ok");

                }

            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);

                await _pageDialogService.DisplayAlertAsync("Aviso", "Falha ao criar usuário", "Ok");
            }
            UserDialogs.Instance.HideLoading();
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
