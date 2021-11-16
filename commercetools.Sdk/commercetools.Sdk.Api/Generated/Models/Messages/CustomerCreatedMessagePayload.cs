using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class CustomerCreatedMessagePayload : ICustomerCreatedMessagePayload
    {
        public string Type { get; set;}
        
        public ICustomer Customer { get; set;}
        public CustomerCreatedMessagePayload()
        { 
           this.Type = "CustomerCreated";
        }
    }
}
