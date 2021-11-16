using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetReturnShipmentStateChange))]
    public partial interface ISetReturnShipmentStateChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        IReturnShipmentState NextValue { get; set;}
        
        IReturnShipmentState PreviousValue { get; set;}
    }
}
