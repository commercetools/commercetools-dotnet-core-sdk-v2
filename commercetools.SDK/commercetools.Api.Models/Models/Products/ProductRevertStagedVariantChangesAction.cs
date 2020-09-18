using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("revertStagedVariantChanges")]
    public class ProductRevertStagedVariantChangesAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
    }
}
