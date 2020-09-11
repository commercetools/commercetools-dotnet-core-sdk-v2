using commercetools.Api.Models.OrderEdits;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditPreviewSuccess), "PreviewSuccess")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditApplied), "Applied")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditPreviewFailure), "PreviewFailure")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditNotProcessed), "NotProcessed")]
    public abstract class OrderEditResult 
    {
        public string Type { get; set;}
    }
}
