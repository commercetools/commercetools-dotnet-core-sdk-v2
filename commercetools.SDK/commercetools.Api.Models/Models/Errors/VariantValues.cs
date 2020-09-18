using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public class VariantValues 
    {
        public string Sku { get; set;}
        
        public List<PriceDraft> Prices { get; set;}
        
        public List<Attribute> Attributes { get; set;}
    }
}
