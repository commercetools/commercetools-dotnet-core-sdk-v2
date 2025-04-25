using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitUpdate : IMyBusinessUnitUpdate
    {
        public long Version { get; set; }

        public IList<IMyBusinessUnitUpdateAction> Actions { get; set; }

        public IEnumerable<IMyBusinessUnitUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
