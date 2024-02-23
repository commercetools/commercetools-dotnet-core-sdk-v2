using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.AssignedProductReference))]
    public partial interface IAssignedProductReference
    {
        IProductReference Product { get; set; }

        IProductVariantSelection VariantSelection { get; set; }

        IProductVariantExclusion VariantExclusion { get; set; }

    }
}
