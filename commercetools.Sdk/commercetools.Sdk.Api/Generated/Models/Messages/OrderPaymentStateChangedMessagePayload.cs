using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderPaymentStateChangedMessagePayload : IOrderPaymentStateChangedMessagePayload
    {
        public string Type { get; set; }

        public IPaymentState PaymentState { get; set; }

        public IPaymentState OldPaymentState { get; set; }
        public OrderPaymentStateChangedMessagePayload()
        {
            this.Type = "OrderPaymentStateChanged";
        }
    }
}
