using Xamarin.Forms;

namespace _QPedido.Views
{
    public partial class Buscar : ContentPage
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListaBusca.SelectedItem = null;
        }
    }
}
