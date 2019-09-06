using Newtonsoft.Json;
using System;

namespace _96h.Models
{
    [Serializable]
    public class ResponseObject<T> where T : class
    {
        [JsonProperty(propertyName: "DATA")]
        public T Response { get; set; }
    }
}
