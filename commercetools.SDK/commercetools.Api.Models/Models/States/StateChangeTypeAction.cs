using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("changeType")]
    public class StateChangeTypeAction : StateUpdateAction
    {
        public string Type { get; set;}
        
        public StateTypeEnum TypeAsEnum => this.Type.GetEnum<StateTypeEnum>();
    }
}
