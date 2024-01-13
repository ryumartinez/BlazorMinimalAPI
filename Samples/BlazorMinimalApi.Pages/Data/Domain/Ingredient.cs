namespace BlazorMinimalApis.Pages.Data.Domain;

public class Ingredient
{
    public int IngredientId { get; set; }
    public int Price { get; set; }
    public string Name { get; set; } = null!;
}