using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateSuccessResult))]
    public partial interface IVariantBulkUpdateSuccessResult : IVariantBulkUpdateResult
    {
        IVariantBulkUpdateResource Resource { get; set; }

    }
}
