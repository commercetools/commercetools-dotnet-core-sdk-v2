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

    public partial class CartDiscountStoreRemovedMessagePayload : ICartDiscountStoreRemovedMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }
        public CartDiscountStoreRemovedMessagePayload()
        {
            this.Type = "CartDiscountStoreRemoved";
        }
    }
}
