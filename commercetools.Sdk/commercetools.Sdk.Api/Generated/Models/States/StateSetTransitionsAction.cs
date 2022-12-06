using System.Collections.Generic;
using System.Linq;


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
