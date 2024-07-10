using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductVariantSelectionIncludeAllExcept : IProductVariantSelectionIncludeAllExcept
    {
        public IProductVariantSelectionTypeEnum Type { get; set; }

        public IList<string> Skus { get; set; }
        public IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }

        public ProductVariantSelectionIncludeAllExcept()
        {
            this.Type = IProductVariantSelectionTypeEnum.FindEnum("includeAllExcept");
        }
    }
}
