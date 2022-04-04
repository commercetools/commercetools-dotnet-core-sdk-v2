using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Customers
{
    public partial class CustomerSetStoresAction : ICustomerSetStoresAction
    {
        public string Action { get; set; }

        public List<IStoreResourceIdentifier> Stores { get; set; }
        public CustomerSetStoresAction()
        {
            this.Action = "setStores";
        }
    }
}
