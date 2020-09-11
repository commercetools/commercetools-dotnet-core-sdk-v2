using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderStateTransitionMessagePayload : MessagePayload
    {
        public StateReference State { get; set;}
        
        public bool Force { get; set;}
    }
}
