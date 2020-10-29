using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderReturnInfoAddedMessagePayload))]
    public interface IOrderReturnInfoAddedMessagePayload : IMessagePayload
    {
        IReturnInfo ReturnInfo { get; set;}
    }
}
