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
    public class BuscarViewModel : BaseViewModel, INavigationAware
    {

        private readonly INavigationService _navigationService;

        private readonly IPageDialogService _pageDialogService;

        private ObservableCollection<EnderecoEmpresa> _lista;

        public ObservableCollection<EnderecoEmpresa> Lista
        {
            get { return _lista; }
            set { SetProperty(ref _lista, value); }
        }


        public BuscarViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
            BuscarEstabelecimentos();

        }

        private async void BuscarEstabelecimentos()
        {

            try
            {
                UserDialogs.Instance.ShowLoading("Carregando", MaskType.Gradient);
                var client = new HttpClient();
                client.BaseAddress = new Uri(ServidorLocal);
                

                var response = await client.GetAsync("qPedido/ws/enderecoEmpresa/" + "SE");

                if (response.IsSuccessStatusCode)
                {
                    var respStr = await response.Content.ReadAsStringAsync();
                    Lista = JsonConvert.DeserializeObject<ObservableCollection<EnderecoEmpresa>>(respStr);

                }

            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);

                await _pageDialogService.DisplayAlertAsync("Aviso", "Falha ao buscar estabelecimentos", "Ok");
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
