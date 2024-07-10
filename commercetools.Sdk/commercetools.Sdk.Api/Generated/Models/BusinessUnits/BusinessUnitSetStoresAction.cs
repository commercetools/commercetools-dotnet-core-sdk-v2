using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
