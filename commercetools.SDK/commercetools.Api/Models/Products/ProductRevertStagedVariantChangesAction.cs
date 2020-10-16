using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("revertStagedVariantChanges")]
    public partial class ProductRevertStagedVariantChangesAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        public ProductRevertStagedVariantChangesAction()
        { 
           this.Action = "revertStagedVariantChanges";
        }
    }
}
