using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("changePrice")]
    public class ProductChangePriceAction : ProductUpdateAction
    {
        public string PriceId { get; set;}
        
        public PriceDraft Price { get; set;}
        
        public bool Staged { get; set;}
    }
}
