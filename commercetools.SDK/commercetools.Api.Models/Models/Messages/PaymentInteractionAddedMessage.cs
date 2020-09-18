using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentInteractionAdded")]
    public class PaymentInteractionAddedMessage : Message
    {
        public CustomFields Interaction { get; set;}
    }
}
