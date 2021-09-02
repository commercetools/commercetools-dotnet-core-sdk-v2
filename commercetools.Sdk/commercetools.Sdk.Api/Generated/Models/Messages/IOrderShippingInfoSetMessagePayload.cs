using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderShippingInfoSetMessagePayload))]
    public partial interface IOrderShippingInfoSetMessagePayload : IMessagePayload
    {
        IShippingInfo ShippingInfo { get; set; }

        IShippingInfo OldShippingInfo { get; set; }
    }
}
