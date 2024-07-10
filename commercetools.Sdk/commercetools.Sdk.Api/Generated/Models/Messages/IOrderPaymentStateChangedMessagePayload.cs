using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentStateChangedMessagePayload))]
    public partial interface IOrderPaymentStateChangedMessagePayload : IOrderMessagePayload
    {
        IPaymentState PaymentState { get; set; }

        IPaymentState OldPaymentState { get; set; }

    }
}
