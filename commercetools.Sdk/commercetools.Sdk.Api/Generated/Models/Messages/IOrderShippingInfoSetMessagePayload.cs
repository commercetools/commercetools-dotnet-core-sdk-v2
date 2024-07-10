using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderShippingInfoSetMessagePayload))]
    public partial interface IOrderShippingInfoSetMessagePayload : IOrderMessagePayload
    {
        IShippingInfo ShippingInfo { get; set; }

        IShippingInfo OldShippingInfo { get; set; }

    }
}
