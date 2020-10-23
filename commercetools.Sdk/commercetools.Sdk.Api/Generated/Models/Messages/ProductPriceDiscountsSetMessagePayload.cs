using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public  partial class ProductPriceDiscountsSetMessagePayload : IProductPriceDiscountsSetMessagePayload
    {
        public string Type { get; set;}
        
        public List<IProductPriceDiscountsSetUpdatedPrice> UpdatedPrices { get; set;}
        public ProductPriceDiscountsSetMessagePayload()
        { 
           this.Type = "ProductPriceDiscountsSet";
        }
    }
}
