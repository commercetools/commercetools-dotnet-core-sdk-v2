using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.Parcel))]
    public partial interface IParcel 
    {
        string Id { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        IParcelMeasurements Measurements { get; set;}
        
        ITrackingData TrackingData { get; set;}
        
        List<IDeliveryItem> Items { get; set;}
    }
}
