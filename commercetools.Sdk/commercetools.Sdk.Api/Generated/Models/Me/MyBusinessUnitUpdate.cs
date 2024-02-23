using commercetools.Sdk.Api.Models.BusinessUnits;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitUpdate : IMyBusinessUnitUpdate
    {
        public long Version { get; set; }

        public IList<IBusinessUnitUpdateAction> Actions { get; set; }
        public IEnumerable<IBusinessUnitUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
