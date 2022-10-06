using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetStoreModeAction : IBusinessUnitSetStoreModeAction
    {
        public string Action { get; set; }

        public IBusinessUnitStoreMode StoreMode { get; set; }

        public List<IStoreResourceIdentifier> Stores { get; set; }
        public BusinessUnitSetStoreModeAction()
        {
            this.Action = "setStoreMode";
        }
    }
}
