namespace content_hub_one_web_app.Models;
public class SitecoreOption
{
    public static readonly string Key = "SITECORE";
    public string CHO_Organization_ID { get; set; }
    public string CHO_Tenant_ID { get; set; }
    public Uri InstanceUri { get; set; }
    public string CHO_Client_ID { get; set; }
    public string CHO_Client_Secret { get; set; }
    public string CHO_Dev_Auth_Token { get; set; }
}