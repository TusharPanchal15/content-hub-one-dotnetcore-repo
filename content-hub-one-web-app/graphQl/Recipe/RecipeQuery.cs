public static class RecipeQuery
{
    public const string Recipe = $@"
        id
        Title: recipeTitle
        Name: name
        Ingredients: ingredients
        Duration: minutesToPrepare
        Description: preparationDescription
        preparationDescriptionRt
        ImageList: image {{
            total
            results {{
                {MediaQuery.Query}
            }}
        }}
    ";

    public const string AllRecipe = $@"
        {{
            data: allRecipe {{
                __typename
                total
                results {{
                    {Recipe}
                }}
            }}
        }}
    ";
}