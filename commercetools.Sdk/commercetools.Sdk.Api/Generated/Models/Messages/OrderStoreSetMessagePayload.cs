using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderStoreSetMessagePayload : IOrderStoreSetMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }
        public OrderStoreSetMessagePayload()
        {
            this.Type = "OrderStoreSet";
        }
    }
}
