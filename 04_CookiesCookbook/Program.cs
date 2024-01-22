

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepositroy(),
    new RecipesConsoleUserInteraction(new IngredientRegistery()));
cookiesRecipesApp.Run("recpies.txt");


