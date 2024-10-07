using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddAssetAction))]
    public partial interface IProductTailoringAddAssetAction : IProductTailoringUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        bool? Staged { get; set; }

        IAssetDraft Asset { get; set; }

        int? Position { get; set; }

    }
}
