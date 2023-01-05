using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SteamDB.KeepUp.SteamCommunication.Models{
    [DataContract]
    public class SteamAppsNews{

    [DataMember]
    [JsonProperty("appnews")]
    public AppNews appnews {get;set;}
        
    }
}