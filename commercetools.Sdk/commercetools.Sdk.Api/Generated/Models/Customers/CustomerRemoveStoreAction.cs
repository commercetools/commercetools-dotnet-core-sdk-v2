using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public  partial class CustomerRemoveStoreAction : ICustomerRemoveStoreAction
    {
        public string Action { get; set;}
        
        public IStoreResourceIdentifier Store { get; set;}
        public CustomerRemoveStoreAction()
        { 
           this.Action = "removeStore";
        }
    }
}
