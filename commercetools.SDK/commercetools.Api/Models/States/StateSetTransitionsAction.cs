using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("setTransitions")]
    public partial class StateSetTransitionsAction : StateUpdateAction
    {
        public List<StateResourceIdentifier> Transitions { get; set;}
        public StateSetTransitionsAction()
        { 
           this.Action = "setTransitions";
        }
    }
}
