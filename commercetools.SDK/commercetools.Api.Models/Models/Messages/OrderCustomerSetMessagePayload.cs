using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderCustomerSet")]
    public partial class OrderCustomerSetMessagePayload : MessagePayload
    {
        public CustomerReference Customer { get; set;}
        
        public CustomerGroupReference CustomerGroup { get; set;}
        
        public CustomerReference OldCustomer { get; set;}
        
        public CustomerGroupReference OldCustomerGroup { get; set;}
        public OrderCustomerSetMessagePayload()
        { 
           this.Type = "OrderCustomerSet";
        }
    }
}
