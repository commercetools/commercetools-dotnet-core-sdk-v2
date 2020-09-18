using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderCustomerSet")]
    public class OrderCustomerSetMessagePayload : MessagePayload
    {
        public CustomerReference Customer { get; set;}
        
        public CustomerGroupReference CustomerGroup { get; set;}
        
        public CustomerReference OldCustomer { get; set;}
        
        public CustomerGroupReference OldCustomerGroup { get; set;}
    }
}
