using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomLineItemStateTransition")]
    public partial class CustomLineItemStateTransitionMessage : Message
    {
        public string CustomLineItemId { get; set;}
        
        public DateTime TransitionDate { get; set;}
        
        public long Quantity { get; set;}
        
        public StateReference FromState { get; set;}
        
        public StateReference ToState { get; set;}
        public CustomLineItemStateTransitionMessage()
        { 
           this.Type = "CustomLineItemStateTransition";
        }
    }
}
