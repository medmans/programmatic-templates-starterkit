﻿using Newtonsoft.Json;

namespace Ividence.Programmatic.Renderer.Core.Models
{
    public class Merchant : ModelBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
