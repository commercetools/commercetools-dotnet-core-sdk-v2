using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetStoreModeAction : IBusinessUnitSetStoreModeAction
    {
        public string Action { get; set; }

        public IBusinessUnitStoreMode StoreMode { get; set; }

        public IList<IStoreResourceIdentifier> Stores { get; set; }

        public IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }
        public BusinessUnitSetStoreModeAction()
        {
            this.Action = "setStoreMode";
        }
    }
}
