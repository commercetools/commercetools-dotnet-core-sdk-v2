using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionAssignment : IProductSelectionAssignment
    {
        public IProductReference Product { get; set; }

        public IProductSelectionReference ProductSelection { get; set; }

        public IProductVariantSelection VariantSelection { get; set; }

        public IProductVariantExclusion VariantExclusion { get; set; }
    }
}
