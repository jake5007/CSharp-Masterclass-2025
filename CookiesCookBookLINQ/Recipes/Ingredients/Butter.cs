﻿namespace CookiesCookBookLINQ.Recipes.Ingredients;

public class Butter : Ingredient
{
    public override int Id => 3;
    public override string Name => "Butter";
    public override string PreparationInstruction =>
        $"Melt on low heat. {base.PreparationInstruction}";


}
