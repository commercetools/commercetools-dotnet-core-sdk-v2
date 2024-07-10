using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentInteractionAddedMessagePayload : IPaymentInteractionAddedMessagePayload
    {
        public string Type { get; set; }

        public ICustomFields Interaction { get; set; }
        public PaymentInteractionAddedMessagePayload()
        {
            this.Type = "PaymentInteractionAdded";
        }
    }
}
