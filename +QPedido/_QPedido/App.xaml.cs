using Prism.Unity;
using _QPedido.Views;
using Xamarin.Forms;

namespace _QPedido
{
    public partial class App : PrismApplication
    {
         public static  int ScreenWidth;

        public static int ScreenWHeight;

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/Teste");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<Segunda>();
            Container.RegisterTypeForNavigation<Teste>();
            Container.RegisterTypeForNavigation<Inicial>();
            Container.RegisterTypeForNavigation<Perfil>();
            Container.RegisterTypeForNavigation<Configuracoes>();
            Container.RegisterTypeForNavigation<CadastroUsuario>();
        }

        public App()
        {
            InitializeComponent();
        }
    }
}
