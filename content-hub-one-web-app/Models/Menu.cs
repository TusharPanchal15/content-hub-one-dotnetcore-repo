namespace content_hub_one_web_app.Models;
using System.Collections.Generic;

public class Menu
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Label { get; set; }
    public string Link { get; set; }
    public MediaResults MenuImage { get; set; }
}

public class MenuResults
{
    public string Total { get; set; }
    public List<Menu> Results { get; set; }
}
