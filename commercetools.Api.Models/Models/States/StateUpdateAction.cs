using commercetools.Api.Models.States;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.States
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(StateAddRolesAction), "addRoles")]
    [JsonSubtypes.KnownSubType(typeof(StateChangeInitialAction), "changeInitial")]
    [JsonSubtypes.KnownSubType(typeof(StateChangeKeyAction), "changeKey")]
    [JsonSubtypes.KnownSubType(typeof(StateChangeTypeAction), "changeType")]
    [JsonSubtypes.KnownSubType(typeof(StateRemoveRolesAction), "removeRoles")]
    [JsonSubtypes.KnownSubType(typeof(StateSetDescriptionAction), "setDescription")]
    [JsonSubtypes.KnownSubType(typeof(StateSetNameAction), "setName")]
    [JsonSubtypes.KnownSubType(typeof(StateSetRolesAction), "setRoles")]
    [JsonSubtypes.KnownSubType(typeof(StateSetTransitionsAction), "setTransitions")]
    public abstract class StateUpdateAction 
    {
        public string Action { get; set;}
    }
}
