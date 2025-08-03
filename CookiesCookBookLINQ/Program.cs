
using CookiesCookBookLINQ.App;
using CookiesCookBookLINQ.FileAccess;
using CookiesCookBookLINQ.DataAccess;
using CookiesCookBookLINQ.Recipes;
using CookiesCookBookLINQ.Recipes.Ingredients;

const FileFormat Format = FileFormat.Json;

var appPath = Format == FileFormat.Json ?
    AppPaths.LocalJsonPath :
    AppPaths.LocalTxtPath;

IStringsRepository stringsRepository = Format == FileFormat.Json ?
    new StringsJsonRepository() :
    new StringsTextualRepository();

const string FileName = "recipes";
var fileMetadata = new FileMetadata(appPath, FileName, Format);

var ingredientsRegister = new IngredientsRegister();

var cookieRecipesApp = new CookieRecipesApp(
    new RecipesRepository(stringsRepository, ingredientsRegister),
    new RecipesConsoleUserInteraction(ingredientsRegister));
cookieRecipesApp.Run(fileMetadata.ToPath());





