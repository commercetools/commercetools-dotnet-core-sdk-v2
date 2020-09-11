using commercetools.Api.Models.Extensions;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Extensions
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ExtensionAzureFunctionsAuthentication), "AzureFunctions")]
    [JsonSubtypes.KnownSubType(typeof(ExtensionAuthorizationHeaderAuthentication), "AuthorizationHeader")]
    public abstract class ExtensionHttpDestinationAuthentication 
    {
        public string Type { get; set;}
    }
}
