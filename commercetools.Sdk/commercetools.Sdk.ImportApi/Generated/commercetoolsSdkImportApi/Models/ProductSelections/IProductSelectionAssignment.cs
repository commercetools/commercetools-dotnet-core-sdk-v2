using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.ProductSelections.ProductSelectionAssignment))]
    public partial interface IProductSelectionAssignment
    {
        IProductKeyReference Product { get; set; }

        IVariantSelection VariantSelection { get; set; }

        IVariantExclusion VariantExclusion { get; set; }

    }
}
