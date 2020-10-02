using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderStoreSet")]
    public partial class OrderStoreSetMessage : Message
    {
        public StoreKeyReference Store { get; set;}
        public OrderStoreSetMessage()
        { 
           this.Type = "OrderStoreSet";
        }
    }
}
