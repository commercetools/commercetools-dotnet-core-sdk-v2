using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("removeStore")]
    public partial class CustomerRemoveStoreAction : CustomerUpdateAction
    {
        public StoreResourceIdentifier Store { get; set;}
        public CustomerRemoveStoreAction()
        { 
           this.Action = "removeStore";
        }
    }
}
