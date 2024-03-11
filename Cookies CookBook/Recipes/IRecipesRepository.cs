namespace Cookies_CookBook.Recipes;

public interface IRecipesRepository
{
    List<Recipe> ReadRecipesFromFile(string filePath);
    void WriteRecipesToFile(string filePath, List<Recipe> allRecipes);
}
