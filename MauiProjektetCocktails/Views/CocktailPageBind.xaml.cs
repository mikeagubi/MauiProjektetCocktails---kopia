using MauiProjektetCocktails.ViewModels;
using System.Diagnostics;

namespace MauiProjektetCocktails.Views;

public partial class CocktailPageBind : ContentPage
{
	public CocktailPageBind(List<Models.Cocktail> cocktails)
	{
        
        InitializeComponent();
        
        var viewModel = new CocktailPageViewModel
        {
            TheCocktails = cocktails
        };
        
        BindingContext = viewModel;

    }
}