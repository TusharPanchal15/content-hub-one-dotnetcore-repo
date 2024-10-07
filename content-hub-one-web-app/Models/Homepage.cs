public class Homepage
{
    public Header Header { get; set; }
    public HeroBanner HeroBanner { get; set; }
    public string RecipeTitle { get; set; }
    public string RecipeSectionText { get; set; }
    public Footer Footer { get; set; }
}

public class HeroBanner
{
    public List<Media> Results { get; set; }
}