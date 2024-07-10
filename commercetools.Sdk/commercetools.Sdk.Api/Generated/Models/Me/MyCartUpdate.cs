using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartUpdate : IMyCartUpdate
    {
        public long Version { get; set; }

        public IList<IMyCartUpdateAction> Actions { get; set; }
        public IEnumerable<IMyCartUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
