using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddParcelToDeliveryAction))]
    public partial interface IStagedOrderAddParcelToDeliveryAction : IStagedOrderUpdateAction
    {
        string DeliveryId { get; set;}
        
        IParcelMeasurements Measurements { get; set;}
        
        ITrackingData TrackingData { get; set;}
        
        List<IDeliveryItem> Items { get; set;}
    }
}
