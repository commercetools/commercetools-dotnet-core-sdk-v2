using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderStateTransition")]
    public partial class OrderStateTransitionMessage : Message
    {
        public StateReference State { get; set;}
        
        public bool Force { get; set;}
        public OrderStateTransitionMessage()
        { 
           this.Type = "OrderStateTransition";
        }
    }
}
