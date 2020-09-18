using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderCustomerGroupSet")]
    public class OrderCustomerGroupSetMessagePayload : MessagePayload
    {
        public CustomerGroupReference CustomerGroup { get; set;}
        
        public CustomerGroupReference OldCustomerGroup { get; set;}
    }
}
