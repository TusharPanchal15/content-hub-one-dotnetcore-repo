namespace content_hub_one_web_app.Models;
public class Header
{
    public string Id { get; set; }
    public string Name { get; set; }
    public MediaResults Logo { get; set; }
    public MenuResults MenuItems { get; set; }
}
public class HeaderResults
{
    public string Total { get; set; }
    public List<Header> Results { get; set; }
}