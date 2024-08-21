using MauiProjektetCocktails.Views;

namespace MauiProjektetCocktails
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private async void OnClickedGoMenuPage(object sender, EventArgs e)
        {
            string userName = NameEntry.Text;
            await Navigation.PushAsync(new MenuPage(userName));
        }
    }

}
