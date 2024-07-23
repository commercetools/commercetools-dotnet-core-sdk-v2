using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetStoresAction : ICustomerSetStoresAction
    {
        public string Action { get; set; }

        public IList<IStoreResourceIdentifier> Stores { get; set; }
        public IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }

        public CustomerSetStoresAction()
        {
            this.Action = "setStores";
        }
    }
}
