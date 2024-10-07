namespace content_hub_one_web_app.Models;
using Newtonsoft.Json.Linq;
public class Recipe
{
    public string Title { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Ingredients { get; set; }
    public string Duration { get; set; }
    public string Description { get; set; }
    public JObject PreparationDescriptionRt { get; set; }  // Assuming JSONContent is JSON, using JObject from Newtonsoft.Json
    public MediaResults ImageList { get; set; }
}

public class RecipeResults
{
    public string Total { get; set; }
    public List<Recipe> Results { get; set; }
}