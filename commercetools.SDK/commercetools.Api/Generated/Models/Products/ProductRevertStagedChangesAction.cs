using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("revertStagedChanges")]
    public partial class ProductRevertStagedChangesAction : ProductUpdateAction
    {
        public ProductRevertStagedChangesAction()
        { 
           this.Action = "revertStagedChanges";
        }
    }
}
