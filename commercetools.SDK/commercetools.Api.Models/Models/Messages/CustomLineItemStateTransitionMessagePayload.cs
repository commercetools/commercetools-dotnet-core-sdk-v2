using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomLineItemStateTransition")]
    public partial class CustomLineItemStateTransitionMessagePayload : MessagePayload
    {
        public string CustomLineItemId { get; set;}
        
        public DateTime TransitionDate { get; set;}
        
        public long Quantity { get; set;}
        
        public StateReference FromState { get; set;}
        
        public StateReference ToState { get; set;}
        public CustomLineItemStateTransitionMessagePayload()
        { 
           this.Type = "CustomLineItemStateTransition";
        }
    }
}
