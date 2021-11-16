using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.Delivery))]
    public partial interface IDelivery 
    {
        string Id { get; set;}
        
        string CreatedAt { get; set;}
        
        List<IDeliveryItem> Items { get; set;}
        
        List<IParcel> Parcels { get; set;}
        
        IAddress Address { get; set;}
    }
}
