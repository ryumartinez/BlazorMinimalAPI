using BlazorMinimalApis.Lib.Routing;
using BlazorMinimalApis.Pages.Data;

namespace BlazorMinimalApis.Pages.Pages.Ingredient;

public class ListIngredients(RambosaDbContext dbContext) : XPage
{
    public List<Data.Domain.Ingredient> Ingredients = new();

    public IResult Get(HttpContext context)
    {
        Ingredients = dbContext.Ingredients.ToList();
        return Page<_ListIngredients>();
    }
}