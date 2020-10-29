using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.VariantValues))]
    public interface IVariantValues 
    {
        string Sku { get; set;}
        
        List<IPriceDraft> Prices { get; set;}
        
        List<IAttribute> Attributes { get; set;}
    }
}
