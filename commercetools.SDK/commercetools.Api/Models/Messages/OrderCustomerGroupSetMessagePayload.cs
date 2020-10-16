using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderCustomerGroupSet")]
    public partial class OrderCustomerGroupSetMessagePayload : MessagePayload
    {
        public CustomerGroupReference CustomerGroup { get; set;}
        
        public CustomerGroupReference OldCustomerGroup { get; set;}
        public OrderCustomerGroupSetMessagePayload()
        { 
           this.Type = "OrderCustomerGroupSet";
        }
    }
}
