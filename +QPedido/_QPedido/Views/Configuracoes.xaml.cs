using Xamarin.Forms;

namespace _QPedido.Views
{
    public partial class Configuracoes : ContentPage
    {
        public Configuracoes()
        {
            InitializeComponent();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }
    }
}
