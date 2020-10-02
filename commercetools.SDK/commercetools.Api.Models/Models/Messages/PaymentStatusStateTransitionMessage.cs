using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentStatusStateTransition")]
    public partial class PaymentStatusStateTransitionMessage : Message
    {
        public StateReference State { get; set;}
        
        public bool Force { get; set;}
        public PaymentStatusStateTransitionMessage()
        { 
           this.Type = "PaymentStatusStateTransition";
        }
    }
}
