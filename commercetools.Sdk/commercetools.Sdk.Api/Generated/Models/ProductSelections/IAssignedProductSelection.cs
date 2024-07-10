using System;
using commercetools.Base.CustomAttributes;

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
