using commercetools.Sdk.Api.Models.BusinessUnits;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitUpdate : IMyBusinessUnitUpdate
    {
        public long Version { get; set; }

        public List<IBusinessUnitUpdateAction> Actions { get; set; }
    }
}
