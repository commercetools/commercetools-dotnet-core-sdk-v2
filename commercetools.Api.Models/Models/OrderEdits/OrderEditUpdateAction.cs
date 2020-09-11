using commercetools.Api.Models.OrderEdits;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditAddStagedActionAction), "addStagedAction")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditSetCommentAction), "setComment")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditSetKeyAction), "setKey")]
    [JsonSubtypes.KnownSubType(typeof(OrderEditSetStagedActionsAction), "setStagedActions")]
    public abstract class OrderEditUpdateAction 
    {
        public string Action { get; set;}
    }
}
