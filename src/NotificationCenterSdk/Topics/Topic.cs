﻿using System.Text.Json.Serialization;

namespace NotificationCenterSdk.Topics;

public class Topic
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("notificationTemplates")]
    public Dictionary<string, NotificationTemplate> NotificationTemplates { get; set; }
}