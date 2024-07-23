using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerUpdate : IMyCustomerUpdate
    {
        public long Version { get; set; }

        public IList<IMyCustomerUpdateAction> Actions { get; set; }
        public IEnumerable<IMyCustomerUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
