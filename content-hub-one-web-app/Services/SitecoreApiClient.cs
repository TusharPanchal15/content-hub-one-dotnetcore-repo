namespace content_hub_one_web_app.Services;

using Newtonsoft.Json.Linq;
using System.Text;
public class SitecoreApiClient
{
    private static readonly HttpClient _httpClient = new HttpClient();

    public async Task<JObject> FetchAPIAsync(string query)
    {
        var endpointUrl = Environment.GetEnvironmentVariable("SITECORE_ENDPOINT_URL");
        var authToken = Environment.GetEnvironmentVariable("SITECORE_DEV_AUTH_TOKEN");

        if (string.IsNullOrEmpty(endpointUrl) || string.IsNullOrEmpty(authToken))
        {
            throw new InvalidOperationException("Environment variables SITECORE_ENDPOINT_URL or SITECORE_DEV_AUTH_TOKEN are not set.");
        }

        var request = new HttpRequestMessage(HttpMethod.Post, endpointUrl)
        {
            Content = new StringContent(
                $"{{ \"query\": \"{query}\" }}",
                Encoding.UTF8,
                "application/json")
        };

        request.Headers.Add("X-GQL-Token", authToken);

        var response = await _httpClient.SendAsync(request);

        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Request failed with status code {response.StatusCode}");
        }

        var responseBody = await response.Content.ReadAsStringAsync();
        return JObject.Parse(responseBody); // Using JObject for JSON parsing
    }
}