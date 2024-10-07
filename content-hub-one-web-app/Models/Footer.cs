namespace content_hub_one_web_app.Models;

using System.Collections.Generic;

public class Footer
{
    public string Id { get; set; }
    public string Name { get; set; }
    public MenuResults MenuItems { get; set; }
    public string FooterText { get; set; }
}

public class FooterResults
{
    public string Total { get; set; }
    public List<Footer> Results { get; set; }
}