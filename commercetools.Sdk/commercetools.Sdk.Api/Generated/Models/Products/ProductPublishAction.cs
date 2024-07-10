using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
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
