using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetStoresAction : IBusinessUnitSetStoresAction
    {
        public string Action { get; set; }

        public IList<IStoreResourceIdentifier> Stores { get; set; }
        public IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }

        public BusinessUnitSetStoresAction()
        {
            this.Action = "setStores";
        }
    }
}
