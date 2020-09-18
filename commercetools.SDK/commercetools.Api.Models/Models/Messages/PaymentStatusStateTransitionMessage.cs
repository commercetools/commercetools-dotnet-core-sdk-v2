using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentStatusStateTransition")]
    public class PaymentStatusStateTransitionMessage : Message
    {
        public StateReference State { get; set;}
        
        public bool Force { get; set;}
    }
}
