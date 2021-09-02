using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.DeliveryAddedMessagePayload))]
    public partial interface IDeliveryAddedMessagePayload : IMessagePayload
    {
        IDelivery Delivery { get; set; }
    }
}
