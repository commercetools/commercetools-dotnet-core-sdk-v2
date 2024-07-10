using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceKeySetMessagePayload : IProductPriceKeySetMessagePayload
    {
        public string Type { get; set; }

        public long VariantId { get; set; }

        public string PriceId { get; set; }

        public string OldKey { get; set; }

        public string Key { get; set; }

        public bool Staged { get; set; }
        public ProductPriceKeySetMessagePayload()
        {
            this.Type = "ProductPriceKeySet";
        }
    }
}
