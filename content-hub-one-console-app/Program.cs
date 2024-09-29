// See https://aka.ms/new-console-template for more information
using Content_Hub_One_Console_App.Services;
using Newtonsoft.Json;

bool IsContinue = true;
do
{
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("Content Hub One - Operations");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("1. Content Type - Create.........");
    Console.WriteLine("2. Content Type - Update.........");
    Console.WriteLine("3. Content Type - GetByID.........");
    Console.WriteLine("4. Content Type - Delete.........");
    Console.WriteLine("5. Content Item - Create.........");
    Console.WriteLine("6. Content Item - Update.........");
    Console.WriteLine("7. Content Item - GetByID.........");
    Console.WriteLine("8. Content Item - Delete.........");
    Console.WriteLine("9. Media - Upload.........");
    Console.WriteLine("10. Media - Delete.........");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("Enter Number:");
    var operation = Console.ReadLine();
    Console.WriteLine("------------------------------------------------");
    switch (operation)
    {
        case "1":
            var _newCType = await ContentTypeService.Create();
            // Serialize the object to JSON and write on console
            Console.WriteLine(JsonConvert.SerializeObject(_newCType, Formatting.Indented));
            break;
        case "2":
            var _uCType = await ContentTypeService.UpdateByID();
            // Serialize the object to JSON and write on console
            Console.WriteLine(JsonConvert.SerializeObject(_uCType, Formatting.Indented));
            break;
        case "3":
            var _CType = await ContentTypeService.GetByID();
            // Serialize the object to JSON and write on console
            Console.WriteLine(JsonConvert.SerializeObject(_CType, Formatting.Indented));
            break;
        case "4":
            var _dCType = await ContentTypeService.DeleteById();
            // Serialize the object to JSON and write on console
            Console.WriteLine(JsonConvert.SerializeObject(_dCType, Formatting.Indented));
            break;
        case "5":
            var _cItem = await ContentItemService.Create();
            // Serialize the object to JSON and write on console
            Console.WriteLine(JsonConvert.SerializeObject(_cItem, Formatting.Indented));
            break;
        case "6":
            var _uItem = await ContentItemService.Update();
            // Serialize the object to JSON and write on console
            Console.WriteLine(JsonConvert.SerializeObject(_uItem, Formatting.Indented));
            break;
        case "7":
            var _gItem = await ContentItemService.GetByID();
            // Serialize the object to JSON and write on console
            Console.WriteLine(JsonConvert.SerializeObject(_gItem, Formatting.Indented));
            break;
        case "8":
            await ContentItemService.Delete();
            break;
        case "9":
            var _mItem = await MediaService.UploadFile();
            // Serialize the object to JSON and write on console
            Console.WriteLine(JsonConvert.SerializeObject(_mItem, Formatting.Indented));
            break;
        case "10":
            await MediaService.DeleteFile();
            Console.WriteLine("Media Item deleted");
            break;
        default:
            IsContinue = false;
            break;
    }
} while (IsContinue);

