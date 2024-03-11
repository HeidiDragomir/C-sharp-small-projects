using Cookies_CookBook.App;
using Cookies_CookBook.DataAccess;
using Cookies_CookBook.FileAccess;
using Cookies_CookBook.Recipes;
using Cookies_CookBook.Recipes.Ingredients;

const FileFormat Format = FileFormat.Txt;

IStringsRepository stringsRepository = Format == FileFormat.Json ?
    new StringsJsonRepository() :
    new StringsTextualRepository();

const string FileName = "recipes";
var fileMetadata = new FileMetadata(FileName, Format);


var ingredientsRegister = new IngredientsRegister();

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(
        stringsRepository,
        ingredientsRegister),
    new RecipesConsoleUserInteraction(
        ingredientsRegister)
    );
cookiesRecipesApp.Run(fileMetadata.ToPath());


