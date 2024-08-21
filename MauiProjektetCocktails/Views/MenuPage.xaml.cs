namespace MauiProjektetCocktails.Views;

public partial class MenuPage : ContentPage
{
	public MenuPage(string userName)
	{
		InitializeComponent();

        WelcomeLabel.Text = $" **** Hello {userName} ****\n Please Select An Option";
    }

    private async void OnSearchBtnClicked(object sender, EventArgs e)
    {
        string cocktailName = SearchDrink.Text;

        List<Models.Cocktail> cocktails = await ViewModels.CocktailPageViewModel.GetCocktail("cocktail?name=" + cocktailName);
        
        if(cocktails != null && cocktails.Count > 0)
        {
            await Navigation.PushAsync(new Views.CocktailPageBind(cocktails));
        }
        else
        {
            await DisplayAlert("No Results", "No cocktails found with that name. Please try another name.", "OK");
        }



    }


}