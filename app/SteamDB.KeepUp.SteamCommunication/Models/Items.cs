using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SteamDB.KeepUp.SteamCommunication.Models{

    public class Items{
        public Items()
        {
            
        }

        [DataMember]
        [JsonProperty("gid")]
        public string id {get;set;}

        [DataMember]
        [JsonProperty("title")]
        public string title {get;set;}

        [DataMember]
        [JsonProperty("url")]
        public string url {get;set;}

        [DataMember]
        [JsonProperty("is_external_url")]
        public bool isExternal {get;set;}

        [DataMember]
        [JsonProperty("author")]
        public string author {get;set;}

        [DataMember]
        [JsonProperty("contents")]
        public string contents{get;set;}

        [DataMember]
        [JsonProperty("feedlabel")]
        public string feedlabel {get;set;}

        [DataMember]
        [JsonProperty("date")]
        public uint date {get;set;}

        [DataMember]
        [JsonProperty("feedname")]
        public string feedname {get;set;}

        [DataMember]
        [JsonProperty("feed_type")]
        public int feed_type {get;set;}

        [DataMember]
        [JsonProperty("appid")]
        public long appid {get;set;}

    }
}