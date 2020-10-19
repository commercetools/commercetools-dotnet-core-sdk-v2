using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("changeInitial")]
    public partial class StateChangeInitialAction : StateUpdateAction
    {
        public bool Initial { get; set;}
        public StateChangeInitialAction()
        { 
           this.Action = "changeInitial";
        }
    }
}
