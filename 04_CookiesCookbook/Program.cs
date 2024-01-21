

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepositroy(),
    new RecipesConsoleUserInteraction());
cookiesRecipesApp.Run("recpies.txt");


