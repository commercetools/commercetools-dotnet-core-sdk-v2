using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public  partial class CustomLineItemStateTransitionMessagePayload : ICustomLineItemStateTransitionMessagePayload
    {
        public string Type { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public DateTime TransitionDate { get; set;}
        
        public long Quantity { get; set;}
        
        public IStateReference FromState { get; set;}
        
        public IStateReference ToState { get; set;}
        public CustomLineItemStateTransitionMessagePayload()
        { 
           this.Type = "CustomLineItemStateTransition";
        }
    }
}
