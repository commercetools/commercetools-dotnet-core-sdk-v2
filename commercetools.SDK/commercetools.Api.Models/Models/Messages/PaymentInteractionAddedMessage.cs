using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentInteractionAdded")]
    public partial class PaymentInteractionAddedMessage : Message
    {
        public CustomFields Interaction { get; set;}
        public PaymentInteractionAddedMessage()
        { 
           this.Type = "PaymentInteractionAdded";
        }
    }
}
