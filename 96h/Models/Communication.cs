using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace _96h.Models
{
    [Serializable]
    public class COMPANY
    {
        [JsonProperty("name")]
        public string name { get; set; }
        public string Edrpou { get; set; }
        public string edrpou { get; set; }
    }
    [Serializable]
    public class Child
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("edrpou")]
        public string edrpou { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
    }
    [Serializable]
    public class DIRECTOR
    {
        [JsonProperty("children")]
        public List<Child> children { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
    }
    [Serializable]
    public class FOUNDER2
    {
        [JsonProperty("children")]
        public List<Child> children { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
    }
    [Serializable]
    public class Communication
    {
        [JsonProperty("COMPANY")]
        public COMPANY COMPANY { get; set; }
        [JsonProperty("DIRECTOR")]
        public DIRECTOR DIRECTOR { get; set; }
        [JsonProperty("FOUNDERS")]
        public List<FOUNDER2> FOUNDERS { get; set; }
    }
}
