using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    public abstract partial class StateUpdateAction : IStateUpdateAction
    {
        public string Action { get; set;}
    }
}
