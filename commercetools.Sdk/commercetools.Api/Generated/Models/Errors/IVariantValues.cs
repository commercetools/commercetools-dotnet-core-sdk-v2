using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Products;
using Attribute = commercetools.Api.Generated.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Errors
{
    public interface IVariantValues 
    {
        string Sku { get; set;}
        
        List<IPriceDraft> Prices { get; set;}
        
        List<IAttribute> Attributes { get; set;}
    }
}
