using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderAddParcelToDeliveryAction))]
    public partial interface IOrderAddParcelToDeliveryAction : IOrderUpdateAction
    {
        string DeliveryId { get; set;}
        
        IParcelMeasurements Measurements { get; set;}
        
        ITrackingData TrackingData { get; set;}
        
        List<IDeliveryItem> Items { get; set;}
    }
}
