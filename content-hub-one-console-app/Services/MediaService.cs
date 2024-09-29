using System.Globalization;
using Content_Hub_One_Console_App.Helper;
using Sitecore.ContentHubOne.Sdk.Model;
using Sitecore.ContentHubOne.Sdk.Resources;
using Sitecore.ContentHubOne.Sdk.Upload;
namespace Content_Hub_One_Console_App.Services
{
    public class MediaService
    {
        private static CultureInfo culture = new CultureInfo("en-US");
        public static async Task<MediaItem?> UploadFile()
        {
            var imgPath = @"C:\TUSHAR\CHO\content-hub-one-repo\content-hub-one-console-app\Images\Cooking\rawpixel-752533.jpg";
            FileUploadSource _upload = new FileUploadSource(imgPath)
            {
                Name = "rawpixel-752533.jpg"
            };

            MediaItem mediaItem = new MediaItem()
            {
                Name = "rawpixel-752533.jpg",
                Description = "rawpixel-752533.jpg",
                Id = "lfVUCFPf5kCmsQNASWXbGA"

            };

            var result = await MConnector.Client.Media.CreateAsync(mediaItem, _upload);
            return result;
        }
        public static async Task DeleteFile()
        {
            var mediaId = "lfVUCFPf5kCmsQNASWXbGA";
            await MConnector.Client.Media.DeleteAsync(mediaId);
        }
        public static async Task<MediaItem?> GetMediaItem(string ID)
        {
            var _mitem = await MConnector.Client.Media.SingleAsync(ID);
            return _mitem;
        }
    }
}