using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderStateTransition")]
    public class OrderStateTransitionMessage : Message
    {
        public StateReference State { get; set;}
        
        public bool Force { get; set;}
    }
}
