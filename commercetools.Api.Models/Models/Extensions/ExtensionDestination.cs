using commercetools.Api.Models.Extensions;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Extensions
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ExtensionHttpDestination), "HTTP")]
    [JsonSubtypes.KnownSubType(typeof(ExtensionAWSLambdaDestination), "AWSLambda")]
    public abstract class ExtensionDestination 
    {
        public string Type { get; set;}
    }
}
