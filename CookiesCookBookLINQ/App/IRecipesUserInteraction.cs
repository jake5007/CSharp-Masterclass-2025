using CookiesCookBookLINQ.Recipes;
using CookiesCookBookLINQ.Recipes.Ingredients;

namespace CookiesCookBookLINQ.App;

public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}
