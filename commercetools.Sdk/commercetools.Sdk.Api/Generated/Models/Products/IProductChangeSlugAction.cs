using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductChangeSlugAction))]
    public interface IProductChangeSlugAction : IProductUpdateAction
    {
        ILocalizedString Slug { get; set;}
        
        bool? Staged { get; set;}
    }
}
