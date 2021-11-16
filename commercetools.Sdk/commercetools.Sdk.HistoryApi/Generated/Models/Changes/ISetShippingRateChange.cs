using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetShippingRateChange))]
    public partial interface ISetShippingRateChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        IMoney NextValue { get; set;}
        
        IMoney PreviousValue { get; set;}
    }
}
