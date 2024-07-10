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

    public partial class CartDiscountStoresSetMessagePayload : ICartDiscountStoresSetMessagePayload
    {
        public string Type { get; set; }

        public IList<IStoreKeyReference> Stores { get; set; }
        public IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }

        public CartDiscountStoresSetMessagePayload()
        {
            this.Type = "CartDiscountStoresSet";
        }
    }
}
