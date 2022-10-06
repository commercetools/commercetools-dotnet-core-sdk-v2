using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetStoresAction : IBusinessUnitSetStoresAction
    {
        public string Action { get; set; }

        public List<IStoreResourceIdentifier> Stores { get; set; }
        public BusinessUnitSetStoresAction()
        {
            this.Action = "setStores";
        }
    }
}
