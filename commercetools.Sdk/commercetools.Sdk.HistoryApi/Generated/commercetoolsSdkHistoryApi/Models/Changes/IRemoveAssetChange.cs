using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveAssetChange))]
    public partial interface IRemoveAssetChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAsset PreviousValue { get; set; }

        string CatalogData { get; set; }

        string Variant { get; set; }

    }
}
