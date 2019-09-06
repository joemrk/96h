using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace _96h.Models
{
    [Serializable]
    public class EDR
    {
        [JsonProperty("edrpou")]
        public string edrpou { get; set; }
        [JsonProperty("fName")]
        public string fName { get; set; }
        [JsonProperty("sName")]
        public string sName { get; set; }
        [JsonProperty("address")]
        public string address { get; set; }
        [JsonProperty("director")]
        public string director { get; set; }
        [JsonProperty("kved")]
        public string kved { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("dateLoad")]
        public DateTime dateLoad { get; set; }
    }
    [Serializable]
    public class FOUNDER
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("summ")]
        public string summ { get; set; }
    }
    [Serializable]
    public class FOUNDERS
    {
        [JsonProperty("FOUNDER")]
        public List<FOUNDER> FOUNDER { get; set; }
    }
    [Serializable]
    public class PDV
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("kod_pdv")]
        public string kod_pdv { get; set; }
        [JsonProperty("dat_reestr")]
        public DateTime dat_reestr { get; set; }
    }
    [Serializable]
    public class Dossier
    {
        [JsonProperty("EDR")]
        public EDR EDR { get; set; }
        [JsonProperty("FOUNDERS")]
        public FOUNDERS FOUNDERS { get; set; }
        [JsonProperty("PDV")]
        public PDV PDV { get; set; }
    }
}
