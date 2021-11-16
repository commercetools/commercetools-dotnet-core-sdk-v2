using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetParcelItemsChange))]
    public partial interface ISetParcelItemsChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        IParcelChangeValue Parcel { get; set;}
        
        List<IDeliveryItem> NextValue { get; set;}
        
        List<IDeliveryItem> PreviousValue { get; set;}
    }
}
