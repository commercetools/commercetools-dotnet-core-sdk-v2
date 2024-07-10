using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.AssignedProductSelection))]
    public partial interface IAssignedProductSelection
    {
        IProductSelectionReference ProductSelection { get; set; }

        IProductVariantSelection VariantSelection { get; set; }

        IProductVariantExclusion VariantExclusion { get; set; }

        DateTime CreatedAt { get; set; }

    }
}
