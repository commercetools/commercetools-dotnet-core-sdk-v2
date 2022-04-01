using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.States
{
    public partial class StateSetTransitionsAction : IStateSetTransitionsAction
    {
        public string Action { get; set; }

        public List<IStateResourceIdentifier> Transitions { get; set; }
        public StateSetTransitionsAction()
        {
            this.Action = "setTransitions";
        }
    }
}
