using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderShippingAddressSetMessagePayload))]
    public partial interface IOrderShippingAddressSetMessagePayload : IMessagePayload
    {
        IAddress Address { get; set; }

        IAddress OldAddress { get; set; }
    }
}
