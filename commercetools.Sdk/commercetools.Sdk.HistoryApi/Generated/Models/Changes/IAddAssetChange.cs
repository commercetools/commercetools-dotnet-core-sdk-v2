using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.AddAssetChange))]
    public partial interface IAddAssetChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAsset NextValue { get; set; }

        IAsset PreviousValue { get; set; }
    }
}
