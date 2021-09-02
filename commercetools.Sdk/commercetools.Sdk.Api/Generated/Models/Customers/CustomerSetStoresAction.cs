using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
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
