using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomLineItemStateTransition")]
    public class CustomLineItemStateTransitionMessagePayload : MessagePayload
    {
        public string CustomLineItemId { get; set;}
        
        public DateTime TransitionDate { get; set;}
        
        public long Quantity { get; set;}
        
        public StateReference FromState { get; set;}
        
        public StateReference ToState { get; set;}
    }
}
