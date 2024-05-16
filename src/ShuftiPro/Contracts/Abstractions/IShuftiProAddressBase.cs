﻿using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Converters;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProAddressBase
    {
        [JsonProperty("full_address", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(250, MinimumLength = 2)]
        string FullAddress { get; set; }

		[StringLength(100, MinimumLength = 2)]
		[JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
		string Country { get; set; }

		[JsonProperty("tax_identity_number", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255, MinimumLength = 2)]
        string TaxIdentityNumber { get; set; }

        //[JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        String IssueDate { get; set; }

        [JsonProperty("supported_types", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProAddressType[] SupportedTypes { get; set; }
    }
}
