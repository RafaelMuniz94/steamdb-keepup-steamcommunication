using Newtonsoft.Json;
using SteamDB.KeepUp.SteamCommunication.Controllers;
using SteamDB.KeepUp.SteamCommunication.Services;

SteamController controller = new SteamController(new ConsultarApp());

var x = await controller.ConsultarApp(1981610);
Console.WriteLine(JsonConvert.SerializeObject(x));

Console.WriteLine("===================================");

x = await controller.ConsultarApp(990080);
Console.WriteLine(JsonConvert.SerializeObject(x));