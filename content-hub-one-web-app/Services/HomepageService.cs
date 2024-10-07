
namespace content_hub_one_web_app.Services;

using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

public class HomepageService
{
    private readonly SitecoreApiClient _apiService;

    public HomepageService(SitecoreApiClient apiService)
    {
        _apiService = apiService;
    }

    public async Task<List<Homepage>> GetAllHomepageAsync(bool preview)
    {
        string query = @"
        {
            data: allHomepage {
                total
                results {
                    id
                    name
                    // Add other fields
                }
            }
        }";

        var jsonResponse = await _apiService.FetchAPIAsync(query);
        var data = JObject.Parse(jsonResponse)["data"]["results"];

        return data.ToObject<List<Homepage>>();
    }

    public async Task<Homepage> GetHomepageByIdAsync(string id)
    {
        string query = $@"
        {{
            data: homepage(id: ""{id}"") {{
                id
                name
                // Add other fields
            }}
        }}";

        var jsonResponse = await _apiService.FetchAPIAsync(query);
        var data = JObject.Parse(jsonResponse)["data"];

        return data.ToObject<Homepage>();
    }
}
