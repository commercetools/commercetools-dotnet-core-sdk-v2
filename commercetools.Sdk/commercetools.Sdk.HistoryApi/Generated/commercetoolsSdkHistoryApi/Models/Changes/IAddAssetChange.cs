using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddAssetChange))]
    public partial interface IAddAssetChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAsset PreviousValue { get; set; }

        IAsset NextValue { get; set; }

    }
}
