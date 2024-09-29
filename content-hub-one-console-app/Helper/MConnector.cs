using Sitecore.ContentHubOne.Sdk;
using Sitecore.ContentHubOne.Sdk.Authentication;
using Sitecore.ContentHubOne.Sdk.Contracts;

namespace Content_Hub_One_Console_App.Helper
{

    public static class MConnector
    {
        private static IContentHubOneClient? _client { get; set; }
        private static string _clientId = "XXXXX";
        private static string _clientSecret = "XXXXXX";

        public static IContentHubOneClient Client
        {
            get
            {
                if (_client == null)
                {
                    var credentials = new ClientCredentialsScheme(_clientId, _clientSecret);
                    _client = ContentHubOneClientFactory.Create(credentials);
                }
                return _client;
            }
        }

    }
}