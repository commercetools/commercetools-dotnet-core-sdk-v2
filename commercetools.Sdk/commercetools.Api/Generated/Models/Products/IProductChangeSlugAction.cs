using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductChangeSlugAction : IProductUpdateAction
    {
        ILocalizedString Slug { get; set;}
        
        bool Staged { get; set;}
    }
}
