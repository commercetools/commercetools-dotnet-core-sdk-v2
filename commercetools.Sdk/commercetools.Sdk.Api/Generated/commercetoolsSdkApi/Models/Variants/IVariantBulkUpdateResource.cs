using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateResource))]
    public partial interface IVariantBulkUpdateResource
    {
        string Id { get; set; }

        long Version { get; set; }

    }
}
