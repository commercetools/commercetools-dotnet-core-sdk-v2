using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentInteractionAdded")]
    public partial class PaymentInteractionAddedMessagePayload : MessagePayload
    {
        public CustomFields Interaction { get; set;}
        public PaymentInteractionAddedMessagePayload()
        { 
           this.Type = "PaymentInteractionAdded";
        }
    }
}
