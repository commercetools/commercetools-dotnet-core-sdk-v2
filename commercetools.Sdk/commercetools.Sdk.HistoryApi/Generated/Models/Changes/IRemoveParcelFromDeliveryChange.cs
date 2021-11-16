using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
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
