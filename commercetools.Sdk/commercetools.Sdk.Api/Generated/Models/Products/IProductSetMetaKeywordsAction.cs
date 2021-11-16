using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetMetaKeywordsAction))]
    public partial interface IProductSetMetaKeywordsAction : IProductUpdateAction
    {
        ILocalizedString MetaKeywords { get; set;}
        
        bool? Staged { get; set;}
    }
}
