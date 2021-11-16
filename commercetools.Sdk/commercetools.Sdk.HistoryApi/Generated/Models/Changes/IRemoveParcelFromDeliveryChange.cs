using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveParcelFromDeliveryChange))]
    public partial interface IRemoveParcelFromDeliveryChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string DeliveryId { get; set;}
        
        IParcel PreviousValue { get; set;}
    }
}
