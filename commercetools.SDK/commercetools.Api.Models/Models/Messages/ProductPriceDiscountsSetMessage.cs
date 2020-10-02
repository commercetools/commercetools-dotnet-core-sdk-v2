using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductPriceDiscountsSet")]
    public partial class ProductPriceDiscountsSetMessage : Message
    {
        public List<ProductPriceDiscountsSetUpdatedPrice> UpdatedPrices { get; set;}
        public ProductPriceDiscountsSetMessage()
        { 
           this.Type = "ProductPriceDiscountsSet";
        }
    }
}
