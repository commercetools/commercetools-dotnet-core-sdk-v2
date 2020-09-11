using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductSetDescriptionAction : ProductUpdateAction
    {
        public LocalizedString Description { get; set;}
        
        public bool Staged { get; set;}
    }
}
