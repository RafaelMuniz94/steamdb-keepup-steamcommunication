using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SteamDB.KeepUp.SteamCommunication.Models{
    [DataContract]
    public class AppNews{
        public AppNews()
        {
            items = new List<Items>();
        }

    [DataMember]
    [JsonProperty("appid")]
    public long id {get;set;}
    
    [DataMember]
    [JsonProperty("newsitems")]
    public List<Items> items {get;set;}

    [DataMember]
    [JsonProperty("count")]
    public int count {get;set;}
        
    }
}