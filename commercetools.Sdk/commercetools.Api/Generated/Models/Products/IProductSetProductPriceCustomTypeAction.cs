using commercetools.Api.Generated.Models.Products;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductSetProductPriceCustomTypeAction : IProductUpdateAction
    {
        string PriceId { get; set;}
        
        bool Staged { get; set;}
        
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
