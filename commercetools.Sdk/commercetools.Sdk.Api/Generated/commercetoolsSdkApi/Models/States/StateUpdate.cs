using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.States
{

    public partial class StateUpdate : IStateUpdate
    {
        public long Version { get; set; }

        public IList<IStateUpdateAction> Actions { get; set; }
        public IEnumerable<IStateUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
