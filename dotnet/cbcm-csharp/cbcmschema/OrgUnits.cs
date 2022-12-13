﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using cbcmSchema.OU;
//
//    var orgUnits = OrgUnits.FromJson(jsonString);

namespace cbcmSchema.OU
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class OrgUnits
    {
        [JsonProperty("organizationUnits", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrganizationUnit> OrganizationUnits { get; set; }
    }

    public partial class OrganizationUnit
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("orgUnitPath", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgUnitPath { get; set; }

        private string _orgUnitId = String.Empty;

        [JsonProperty("orgUnitId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgUnitId
        {
            get
            {
                return this.StripToken(this._orgUnitId, "id:");
            }
            set
            {
                this._orgUnitId = value;
            }
        }

        [JsonProperty("parentOrgUnitPath", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOrgUnitPath { get; set; }

        private string _parentOrgUnitId = String.Empty;
        [JsonProperty("parentOrgUnitId", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOrgUnitId
        {
            get
            {
                return this.StripToken(this._parentOrgUnitId, "id:");
            }
            set
            {
                this._parentOrgUnitId = value;
            }
        }

        [JsonProperty("blockInheritance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BlockInheritance { get; set; }

        private string StripToken(string originalText, string token)
        {
            if (String.IsNullOrEmpty(originalText))
                return String.Empty;

            string[] stringSeparators = new string[] { token };

            string[] result = originalText.Split(stringSeparators, StringSplitOptions.None);

            if (result.Length > 1)
                return result[1];

            return originalText;
        }
    }

    public partial class OrgUnits
    {
        public static OrgUnits FromJson(string json) => JsonConvert.DeserializeObject<OrgUnits>(json, cbcmSchema.OU.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this OrgUnits self) => JsonConvert.SerializeObject(self, cbcmSchema.OU.Converter.Settings);
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
