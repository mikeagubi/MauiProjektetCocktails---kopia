using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiProjektetCocktails.ViewModels
{
    public class CocktailPageViewModel
    {
        public  List<Models.Cocktail> TheCocktails { get; set; }
        public CocktailPageViewModel()
        {
            TheCocktails = new List<Models.Cocktail>();
            //var task = Task.Run(() => TheCocktails);
            //task.Wait();
        }

        public static async Task<List<Models.Cocktail>> GetCocktail(string uri)
        {
            List<Models.Cocktail> cocktails = null;
            
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.api-ninjas.com/v1/");
            client.DefaultRequestHeaders.Add("X-API-Key", "7Hj1eGF39Wgbru8h78qkRw==O3anBmvNSlPGMO38");
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                cocktails = JsonSerializer.Deserialize<List<Models.Cocktail>>(responseString);
            }
            return cocktails;
        }




    }
}
