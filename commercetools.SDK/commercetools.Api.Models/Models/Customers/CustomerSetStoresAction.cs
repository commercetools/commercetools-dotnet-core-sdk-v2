using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setStores")]
    public partial class CustomerSetStoresAction : CustomerUpdateAction
    {
        public List<StoreResourceIdentifier> Stores { get; set;}
        public CustomerSetStoresAction()
        { 
           this.Action = "setStores";
        }
    }
}
