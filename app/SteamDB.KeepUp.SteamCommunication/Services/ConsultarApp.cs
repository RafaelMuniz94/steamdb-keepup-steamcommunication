using Newtonsoft.Json;
using SteamDB.KeepUp.SteamCommunication.Models;

namespace SteamDB.KeepUp.SteamCommunication.Services{
    public class ConsultarApp : IConsultarApp
    {
        public async Task<SteamAppsNews> ReturnNewsData(long appId)
        {
            try{
            
            HttpClient client = new HttpClient();
            string baseUrl = "https://api.steampowered.com";
            string route = "/ISteamNews/GetNewsForApp/v0002/";
         
            HttpResponseMessage response = await client.GetAsync(string.Concat(baseUrl,route,$"?appid={appId}"));
            
            response.EnsureSuccessStatusCode();

            SteamAppsNews news = JsonConvert.DeserializeObject<SteamAppsNews>(response.Content.ReadAsStringAsync().Result);

            return news;
            }catch(Exception exception)
            {
                throw;
            }
        }
    }
}