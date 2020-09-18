using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("setTransitions")]
    public class StateSetTransitionsAction : StateUpdateAction
    {
        public List<StateResourceIdentifier> Transitions { get; set;}
    }
}
