using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitUpdate : IBusinessUnitUpdate
    {
        public long Version { get; set; }

        public List<IBusinessUnitUpdateAction> Actions { get; set; }
    }
}
