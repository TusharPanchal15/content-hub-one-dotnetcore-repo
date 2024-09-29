using Content_Hub_One_Console_App.Helper;
using Sitecore.ContentHubOne.Sdk.Resources;
using System.Globalization;
using Sitecore.ContentHubOne.Sdk.Model;

namespace Content_Hub_One_Console_App.Services
{
    public class ContentTypeService
    {
        private static CultureInfo culture = new CultureInfo("en-US");
        public static async Task<ContentType> Create()
        {
            var _fields = new List<IContentTypeField>();
            var _productNameField = new ContentTypeField()
            {
                Id = "productName",
                Name = new Dictionary<CultureInfo, string> { { culture, "Product Name" } },
                Type = FieldType.ShortText,
                Required = false
            };

            var _productDescriptionField = new ContentTypeField()
            {
                Id = "productDescription",
                Name = new Dictionary<CultureInfo, string> { { culture, "Product Description" } },
                Type = FieldType.LongText,
                Required = false
            };

            var _productQuantityField = new ContentTypeField()
            {
                Id = "productQuantity",
                Name = new Dictionary<CultureInfo, string> { { culture, "Product Quantity" } },
                Type = FieldType.Integer,
                Required = false
            };

            var _productImageField = new ContentTypeField()
            {
                Id = "productImage",
                Name = new Dictionary<CultureInfo, string> { { culture, "Image" } },
                Type = FieldType.Media,
                Required = false
            };

            var _productPriceField = new ContentTypeField()
            {
                Id = "productPrice",
                Name = new Dictionary<CultureInfo, string> { { culture, "Price" } },
                Type = FieldType.ShortText,
                Required = false
            };

            _fields.Add(_productNameField);
            _fields.Add(_productDescriptionField);
            _fields.Add(_productQuantityField);
            _fields.Add(_productImageField);
            _fields.Add(_productPriceField);

            var contentType = new ContentType
            {
                Id = "products",
                Name = new Dictionary<CultureInfo, string> { { culture, "products" } },
                Description = new Dictionary<CultureInfo, string> { { culture, "collection of products" } },
                Fields = _fields

            };

            var newContentType = await MConnector.Client.ContentTypes.CreateAsync(contentType);
            return newContentType;

        }
        public static async Task<ContentType?> UpdateByID(string contentTypeID = "products")
        {
            var _releatedProductsField = new ContentTypeField()
            {
                Id = "releatedProducts",
                Name = new Dictionary<CultureInfo, string> { { culture, "Related Products" } },
                Type = FieldType.Reference,
                Required = false
            };
            var contentType = await GetByID(contentTypeID);
            contentType.Fields.Add(_releatedProductsField);
            var newContentType = await MConnector.Client.ContentTypes.UpdateAsync(contentType);
            return newContentType;
        }
        public static async Task<bool> DeleteById(string contentTypeID = "products")
        {
            await MConnector.Client.ContentTypes.DeleteAsync(contentTypeID);
            return true;
        }
        public static async Task<ContentType?> GetByID(string contentTypeID = "products")
        {
            var newContentType = await MConnector.Client.ContentTypes.SingleAsync(contentTypeID);
            return newContentType;
        }
    }
}