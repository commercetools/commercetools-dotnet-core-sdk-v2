using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StateChangeTypeAction))]
    public interface IStateChangeTypeAction : IStateUpdateAction
    {
        string Type { get; set;}
        
        StateTypeEnum TypeAsEnum { get; }
    }
}
