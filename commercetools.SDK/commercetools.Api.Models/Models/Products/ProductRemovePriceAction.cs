using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("removePrice")]
    public partial class ProductRemovePriceAction : ProductUpdateAction
    {
        public string PriceId { get; set;}
        
        public bool Staged { get; set;}
        public ProductRemovePriceAction()
        { 
           this.Action = "removePrice";
        }
    }
}
