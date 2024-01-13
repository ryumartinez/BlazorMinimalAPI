namespace BlazorMinimalApis.Pages.Data.Domain;

public class Ingredient
{
    public int Id { get; set; }
    public int Price { get; set; }
    public string Name { get; set; } = null!;
}