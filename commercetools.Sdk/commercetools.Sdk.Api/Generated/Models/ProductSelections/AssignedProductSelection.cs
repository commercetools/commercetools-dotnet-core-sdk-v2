using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class AssignedProductSelection : IAssignedProductSelection
    {
        public IProductSelectionReference ProductSelection { get; set; }

        public IProductVariantSelection VariantSelection { get; set; }

        public IProductVariantExclusion VariantExclusion { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
