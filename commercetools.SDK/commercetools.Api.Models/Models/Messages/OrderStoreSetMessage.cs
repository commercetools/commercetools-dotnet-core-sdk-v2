using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderStoreSet")]
    public class OrderStoreSetMessage : Message
    {
        public StoreKeyReference Store { get; set;}
    }
}
