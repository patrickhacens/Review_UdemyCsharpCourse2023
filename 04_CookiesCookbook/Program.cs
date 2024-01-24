
var recipeRepo =
    new RecipesRepositroy(new StringTextualRepository(), new IngredientRegistery());

var recipeConsoleUserInteraction =
    new RecipesConsoleUserInteraction(new IngredientRegistery());

var cookiesRecipesApp =
    new CookiesRecipesApp(recipeRepo, recipeConsoleUserInteraction);

cookiesRecipesApp.Run("recpies.txt");


