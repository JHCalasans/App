﻿using Prism.Unity;
using _QPedido.Views;
using Xamarin.Forms;

namespace _QPedido
{
    public partial class App : PrismApplication
    {
        

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/Inicial");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<Segunda>();
            Container.RegisterTypeForNavigation<Inicial>();
            Container.RegisterTypeForNavigation<Perfil>();
            Container.RegisterTypeForNavigation<Configuracoes>();
            Container.RegisterTypeForNavigation<CadastroUsuario>();
            Container.RegisterTypeForNavigation<Buscar>();
        }

        public App()
        {
            InitializeComponent();
        }
    }
}
