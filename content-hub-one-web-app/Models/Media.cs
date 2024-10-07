namespace content_hub_one_web_app.Models;
public class Media
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string FileName { get; set; }
    public string FileUrl { get; set; }
    public string Description { get; set; }
    public string FileWidth { get; set; }
    public string FileHeight { get; set; }
    public string FileId { get; set; }
    public string FileSize { get; set; }
    public string FileType { get; set; }
}

public class MediaResults
{
    public string Total { get; set; }
    public List<Media> Results { get; set; }
}