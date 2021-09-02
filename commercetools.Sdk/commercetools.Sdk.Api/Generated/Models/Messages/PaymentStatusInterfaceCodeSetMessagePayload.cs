using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class PaymentStatusInterfaceCodeSetMessagePayload : IPaymentStatusInterfaceCodeSetMessagePayload
    {
        public string Type { get; set; }

        public string PaymentId { get; set; }

        public string InterfaceCode { get; set; }
        public PaymentStatusInterfaceCodeSetMessagePayload()
        {
            this.Type = "PaymentStatusInterfaceCodeSet";
        }
    }
}
