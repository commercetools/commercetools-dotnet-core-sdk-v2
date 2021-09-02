using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetParcelMeasurementsAction))]
    public partial interface IOrderSetParcelMeasurementsAction : IOrderUpdateAction
    {
        string ParcelId { get; set; }

        IParcelMeasurements Measurements { get; set; }
    }
}
