using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductPublishAction : ProductUpdateAction
    {
        public ProductPublishScope Scope { get; set;}
    }
}
