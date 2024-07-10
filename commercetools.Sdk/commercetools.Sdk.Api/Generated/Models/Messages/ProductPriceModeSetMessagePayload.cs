using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceModeSetMessagePayload : IProductPriceModeSetMessagePayload
    {
        public string Type { get; set; }

        public IProductPriceModeEnum To { get; set; }
        public ProductPriceModeSetMessagePayload()
        {
            this.Type = "ProductPriceModeSet";
        }
    }
}
