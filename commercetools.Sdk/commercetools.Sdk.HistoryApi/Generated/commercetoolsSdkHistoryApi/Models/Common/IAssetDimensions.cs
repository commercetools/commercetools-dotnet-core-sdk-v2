using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.AssetDimensions))]
    public partial interface IAssetDimensions
    {
        int W { get; set; }

        int H { get; set; }

    }
}
