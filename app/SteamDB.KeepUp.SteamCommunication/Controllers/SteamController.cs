using SteamDB.KeepUp.SteamCommunication.Models;
using SteamDB.KeepUp.SteamCommunication.Services;

namespace SteamDB.KeepUp.SteamCommunication.Controllers{
    public class SteamController
    {

        IConsultarApp appService;

         public SteamController(IConsultarApp _appService)
         {
             appService = _appService;
         }

        public async Task<SteamAppsNews> ConsultarApp(long appId){
            return await appService.ReturnNewsData(appId);
            
        }
    }
}