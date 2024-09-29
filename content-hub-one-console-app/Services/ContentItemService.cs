using Content_Hub_One_Console_App.Helper;
using Sitecore.ContentHubOne.Sdk.Model;
using Sitecore.ContentHubOne.Sdk.Resources;
using Newtonsoft.Json;

namespace Content_Hub_One_Console_App.Services
{
    public class ContentItemService
    {
        private const string imageTye = "Link";

        public static async Task<ContentItem> Create(string contentItemId = "product02")
        {

            var _mItem = await MediaService.GetMediaItem("lfVUCFPf5kCmsQNASWXbGA");
            Console.WriteLine(JsonConvert.SerializeObject(_mItem, Formatting.Indented));
            MediaField _mfield = new MediaField()
            {
                Type = FieldType.Media,

            };
            _mfield.Value = _mItem;
            var _contentItem = new ContentItem
            {
                Id = contentItemId,
                Name = "Product 01",
                Fields = new Dictionary<string, BaseField>
                {{
                    "productName", new ShortTextField("Product 01")
                },
                {
                    "productDescription", new LongTextField("Product 01 Description")
                },
                {
                    "productQuantity", new IntegerField(4)
                },
                {
                    "productPrice", new ShortTextField("10.4")
                }
                }
            };
            var _citem = await MConnector.Client.ContentItems.CreateAsync("products", _contentItem);
            return _citem;
        }
        public static async Task<ContentItem> Update(string contentItemId = "product02")
        {
            var _cItem = await MConnector.Client.ContentItems.SingleAsync(contentItemId);
            _cItem.Fields.Remove("productDescription");
            _cItem.Fields.Add("productDescription", new LongTextField("Lorem ipsum dolor sit amet."));
            var _uItem = await MConnector.Client.ContentItems.UpdateAsync(_cItem);
            return _uItem;
        }
        public static async Task Delete(string contentItemId = "product02")
        {
            await MConnector.Client.ContentItems.DeleteAsync(contentItemId);
            Console.WriteLine("Content Hub One - Content Item - Deleted...");
        }
        public static async Task<ContentItem> GetByID(string contentItemId = "product02")
        {
            var _citem = await MConnector.Client.ContentItems.SingleAsync(contentItemId);
            return _citem;
        }
    }

}