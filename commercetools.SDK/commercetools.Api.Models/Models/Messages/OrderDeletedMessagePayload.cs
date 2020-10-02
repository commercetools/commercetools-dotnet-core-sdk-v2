using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderDeleted")]
    public partial class OrderDeletedMessagePayload : MessagePayload
    {
        public Order Order { get; set;}
        public OrderDeletedMessagePayload()
        { 
           this.Type = "OrderDeleted";
        }
    }
}
