using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceDiscountsSetMessagePayload : IProductPriceDiscountsSetMessagePayload
    {
        public string Type { get; set; }

        public IList<IProductPriceDiscountsSetUpdatedPrice> UpdatedPrices { get; set; }
        public IEnumerable<IProductPriceDiscountsSetUpdatedPrice> UpdatedPricesEnumerable { set => UpdatedPrices = value.ToList(); }

        public ProductPriceDiscountsSetMessagePayload()
        {
            this.Type = "ProductPriceDiscountsSet";
        }
    }
}
