using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.States
{

    public partial class StateSetTransitionsAction : IStateSetTransitionsAction
    {
        public string Action { get; set; }

        public IList<IStateResourceIdentifier> Transitions { get; set; }
        public IEnumerable<IStateResourceIdentifier> TransitionsEnumerable { set => Transitions = value.ToList(); }

        public StateSetTransitionsAction()
        {
            this.Action = "setTransitions";
        }
    }
}
