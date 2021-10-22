﻿using JetBrains.Annotations;
using Newtonsoft.Json;
#pragma warning disable 1591

namespace Flowmailer.Models
{
    [PublicAPI]
    public class Header
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}