using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("addStore")]
    public partial class CustomerAddStoreAction : CustomerUpdateAction
    {
        public StoreResourceIdentifier Store { get; set;}
        public CustomerAddStoreAction()
        { 
           this.Action = "addStore";
        }
    }
}
