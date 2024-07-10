using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceCustomFieldChangedMessagePayload : IProductPriceCustomFieldChangedMessagePayload
    {
        public string Type { get; set; }

        public string PriceId { get; set; }

        public long VariantId { get; set; }

        public bool Staged { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public ProductPriceCustomFieldChangedMessagePayload()
        {
            this.Type = "ProductPriceCustomFieldChanged";
        }
    }
}
