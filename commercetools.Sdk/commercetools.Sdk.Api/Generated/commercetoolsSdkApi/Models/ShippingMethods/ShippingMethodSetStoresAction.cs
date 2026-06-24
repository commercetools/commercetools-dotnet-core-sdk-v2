using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodSetStoresAction : IShippingMethodSetStoresAction
    {
        public string Action { get; set; }

        public IList<IStoreResourceIdentifier> Stores { get; set; }

        public IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }
        public ShippingMethodSetStoresAction()
        {
            this.Action = "setStores";
        }
    }
}
