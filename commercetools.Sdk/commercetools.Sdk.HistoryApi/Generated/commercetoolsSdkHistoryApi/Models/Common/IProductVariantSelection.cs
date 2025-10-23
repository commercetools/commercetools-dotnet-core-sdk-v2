using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductVariantSelection))]
    public partial interface IProductVariantSelection
    {
        IProductVariantSelectionTypeEnum Type { get; set; }

    }
}
