using Cookies_CookBook.Recipes.Ingredients;
using Cookies_CookBook.Recipes;

namespace Cookies_CookBook.App;

public interface IRecipesUserInteraction
{
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void ShowMessage(string message);
    void Exit();
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}
