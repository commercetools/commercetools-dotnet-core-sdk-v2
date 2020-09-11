using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderStoreSetMessagePayload : MessagePayload
    {
        public StoreKeyReference Store { get; set;}
    }
}
