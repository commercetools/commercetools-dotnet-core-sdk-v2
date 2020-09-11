using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerRemoveStoreAction : CustomerUpdateAction
    {
        public StoreResourceIdentifier Store { get; set;}
    }
}
