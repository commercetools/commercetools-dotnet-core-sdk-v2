using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    public partial class StateUpdate : IStateUpdate
    {
        public long Version { get; set;}
        
        public List<IStateUpdateAction> Actions { get; set;}
    }
}
