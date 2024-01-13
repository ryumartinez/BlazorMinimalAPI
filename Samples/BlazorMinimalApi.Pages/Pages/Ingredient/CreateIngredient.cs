using System.ComponentModel.DataAnnotations;
using BlazorMinimalApis.Lib.Routing;
using BlazorMinimalApis.Lib.Session;
using BlazorMinimalApis.Pages.Data;
using Microsoft.AspNetCore.Mvc;
using Riok.Mapperly.Abstractions;

namespace BlazorMinimalApis.Pages.Pages.Ingredient;

public class CreateIngredient(RambosaDbContext dbContext) : XPage
{
    public CreateIngredientForm Form = new();

    public IResult Get()
    {
        Form = new CreateIngredientForm();
        return Page<_CreateIngredient>();
    }

    public IResult Post([FromForm] CreateIngredientForm form, SessionManager Session)
    {
        if (Validate(form).HasErrors)
        {
            Form = form;
            return Page<_CreateIngredient>();
        }

        var newIngredient = new CreateIngredientMapper().FormToIngredient(form);
        dbContext.Ingredients.Add(newIngredient);
        
        Session.SetFlash("success", "Ingredient successfully added.");
        return Redirect("/ingredients/create");
    }
}

public class CreateIngredientForm
{
    [Required] public string Name { get; set; }
    [Required] public int Price { get; set; }
}

[Mapper]
public partial class CreateIngredientMapper
{
    public partial CreateIngredientForm IngredientToForm(Data.Domain.Ingredient ingredient);
    public partial Data.Domain.Ingredient FormToIngredient(CreateIngredientForm ingredient);
}