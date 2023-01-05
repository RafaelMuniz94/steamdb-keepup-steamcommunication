using SteamDB.KeepUp.SteamCommunication.Models;

namespace SteamDB.KeepUp.SteamCommunication.Services{

public interface IConsultarApp{
    public Task<SteamAppsNews> ReturnNewsData(long appId);
}

}