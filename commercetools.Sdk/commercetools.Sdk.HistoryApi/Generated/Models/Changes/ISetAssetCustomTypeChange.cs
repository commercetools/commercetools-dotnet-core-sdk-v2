using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetAssetCustomTypeChange))]
    public partial interface ISetAssetCustomTypeChange : IChange
    {
        new string Change { get; set;}
        
        new string Type { get; set;}
        
        IAssetChangeValue Asset { get; set;}
        
        ICustomFields NextValue { get; set;}
        
        ICustomFields PreviousValue { get; set;}
    }
}
