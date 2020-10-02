using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("unpublish")]
    public partial class ProductUnpublishAction : ProductUpdateAction
    {
        public ProductUnpublishAction()
        { 
           this.Action = "unpublish";
        }
    }
}
