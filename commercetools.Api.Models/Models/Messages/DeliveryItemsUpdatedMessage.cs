using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class DeliveryItemsUpdatedMessage : Message
    {
        public string DeliveryId { get; set;}
        
        public List<DeliveryItem> Items { get; set;}
        
        public List<DeliveryItem> OldItems { get; set;}
    }
}
