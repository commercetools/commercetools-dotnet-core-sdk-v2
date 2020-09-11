using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class PaymentInteractionAddedMessage : Message
    {
        public CustomFields Interaction { get; set;}
    }
}
