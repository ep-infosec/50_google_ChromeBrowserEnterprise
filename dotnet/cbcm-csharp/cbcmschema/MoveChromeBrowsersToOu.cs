﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using cbcmSchema.BrowserToOU;
//
//    var moveChromeBrowsersToOu = MoveChromeBrowsersToOu.FromJson(jsonString);

namespace cbcmSchema.BrowserToOU
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class MoveChromeBrowsersToOu
    {
        [JsonProperty("org_unit_path", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgUnitPath { get; set; }

        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ResourceIds { get; set; }
    }

    public partial class MoveChromeBrowsersToOu
    {
        public static MoveChromeBrowsersToOu FromJson(string json) => JsonConvert.DeserializeObject<MoveChromeBrowsersToOu>(json, cbcmSchema.BrowserToOU.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this MoveChromeBrowsersToOu self) => JsonConvert.SerializeObject(self, cbcmSchema.BrowserToOU.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
