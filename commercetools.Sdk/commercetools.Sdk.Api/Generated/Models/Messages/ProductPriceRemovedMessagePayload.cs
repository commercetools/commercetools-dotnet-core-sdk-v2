using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceRemovedMessagePayload : IProductPriceRemovedMessagePayload
    {
        public string Type { get; set; }

        public long VariantId { get; set; }

        public IPrice Price { get; set; }

        public bool Staged { get; set; }
        public ProductPriceRemovedMessagePayload()
        {
            this.Type = "ProductPriceRemoved";
        }
    }
}
