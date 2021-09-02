using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductPublishAction : IProductPublishAction
    {
        public string Action { get; set; }

        public IProductPublishScope Scope { get; set; }
        public ProductPublishAction()
        {
            this.Action = "publish";
        }
    }
}
