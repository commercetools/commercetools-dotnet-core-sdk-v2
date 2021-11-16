using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveAssetChange))]
    public partial interface IRemoveAssetChange : IChange
    {
        new string Change { get; set;}
        
        new string Type { get; set;}
        
        IAsset PreviousValue { get; set;}
    }
}
