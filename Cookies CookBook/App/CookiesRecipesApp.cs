using Cookies_CookBook.Recipes;

namespace Cookies_CookBook.App;

// THE MAIN LOGIC
// The responsability of this class is to manage the workflow of this application
public class CookiesRecipesApp
{
    // dependencies of this class
    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteraction;

    public CookiesRecipesApp(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }
    public void Run(string filePath)
    {
        // 1. Read recipes from the file
        var allRecipes = _recipesRepository.ReadRecipesFromFile(filePath);

        // 2. Print all recipes
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        // 3. Prompt user to start creating a new recipe
        _recipesUserInteraction.PromptToCreateRecipe();

        //// 4. Read the ingredients from the user
        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Count() > 0)
        {
            // 4a. Add the new ingredients to a recipe
            var recipe = new Recipe(ingredients);

            // 4. Add the new recipe to allRecipes
            allRecipes.Add(recipe);

            // 4b. Save all recipes to a file
            _recipesRepository.WriteRecipesToFile(filePath, allRecipes);

            // 4c. Show a message
            _recipesUserInteraction.ShowMessage("Recipe Added:");

            // 4d. Print recipe to the console
            _recipesUserInteraction.ShowMessage(recipe.ToString());

        }
        else
        {
            _recipesUserInteraction.ShowMessage("No ingredients have been selected. Recipe will not be saved.");
        }

        // 5. Exit the application
        _recipesUserInteraction.Exit();
    }
}
