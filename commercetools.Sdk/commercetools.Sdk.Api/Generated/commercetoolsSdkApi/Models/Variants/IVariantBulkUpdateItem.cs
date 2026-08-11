using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateItem))]
    public partial interface IVariantBulkUpdateItem
    {
        string Id { get; set; }

        string Key { get; set; }

        long? Version { get; set; }

    }
}
