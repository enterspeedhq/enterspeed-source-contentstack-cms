﻿using System;
using System.Text.Json.Serialization;

namespace Enterspeed.Source.Contentstack.CMS.Models;

public class ContentstackResource : ContentstackRequest

{
    [JsonPropertyName("module")]
    public string Module { get; set; }

    [JsonPropertyName("event")]
    public string Event { get; set; }

    [JsonPropertyName("triggered_at")]
    public DateTime TriggeredAt { get; set; }

    [JsonPropertyName("data")]
    public object Data { get; set; }
}