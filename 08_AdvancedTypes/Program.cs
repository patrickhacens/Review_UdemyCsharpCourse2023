using _08_AdvancedTypes;
using _08_AdvancedTypes.DTO;
using System.Text.Json;

IApiDataReader starwarsAPI = new StarWarsApiDataReader();

string responseContent = await starwarsAPI.ReadAsync("https://swapi.dev/api/", "planets");

IEnumerable<PlanetsData> planets =
    JsonSerializer.Deserialize<PlanetsDTO>(responseContent).
    results.Select(p =>
     new PlanetsData() { Name = p.name, Diameter = p.diameter, SurfaceWater = p.surface_water, Population = p.population });

var tablePrinter = new UniversalTablePrinter(planets);
tablePrinter.PrintToConsole();


Console.WriteLine("The statistics of which property would you like to see?" +
    $"{Environment.NewLine}population" +
    $"{Environment.NewLine}diameter" +
    $"{Environment.NewLine}surface water");

Console.ReadLine();


public class PlanetsData
{
    public string Name { get; set; }
    public string Diameter { get; set; }
    public string SurfaceWater { get; set; }
    public string Population { get; set; }
}