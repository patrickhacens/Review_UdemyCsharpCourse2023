using _08_AdvancedTypes.DTO;
using System.Text.Json;

var starwars = new StarWarsApiDataReader();

string responseContent = await starwars.ReadAsync("https://swapi.dev/api/", "planets");

PlanetsDTO planets = JsonSerializer.Deserialize<PlanetsDTO>(responseContent);

foreach (var item in planets.results)
{
    Console.WriteLine($"Name : {item.name}," +
        $" Diameter : {item.diameter}," +
        $"SurfaceWater : {item.surface_water}," +
        $"Population : {item.population}");
}


Console.ReadLine();

