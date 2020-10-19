using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderStoreSet")]
    public partial class OrderStoreSetMessagePayload : MessagePayload
    {
        public StoreKeyReference Store { get; set;}
        public OrderStoreSetMessagePayload()
        { 
           this.Type = "OrderStoreSet";
        }
    }
}
