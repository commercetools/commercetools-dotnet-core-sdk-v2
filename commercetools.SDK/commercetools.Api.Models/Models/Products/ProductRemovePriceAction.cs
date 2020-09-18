using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("removePrice")]
    public class ProductRemovePriceAction : ProductUpdateAction
    {
        public string PriceId { get; set;}
        
        public bool Staged { get; set;}
    }
}
