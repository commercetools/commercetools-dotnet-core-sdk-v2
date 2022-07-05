using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.States
{

    public partial class StateUpdate : IStateUpdate
    {
        public long Version { get; set; }

        public List<IStateUpdateAction> Actions { get; set; }
    }
}
