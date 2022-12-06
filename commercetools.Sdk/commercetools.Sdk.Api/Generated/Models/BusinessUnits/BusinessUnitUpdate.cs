using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitUpdate : IBusinessUnitUpdate
    {
        public long Version { get; set; }

        public IList<IBusinessUnitUpdateAction> Actions { get; set; }
        public IEnumerable<IBusinessUnitUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
