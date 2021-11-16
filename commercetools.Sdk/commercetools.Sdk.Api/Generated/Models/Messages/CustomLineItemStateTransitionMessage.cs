using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;


namespace commercetools.Api.Models.Messages
{
    public partial class CustomLineItemStateTransitionMessage : ICustomLineItemStateTransitionMessage
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public long SequenceNumber { get; set;}
        
        public IReference Resource { get; set;}
        
        public long ResourceVersion { get; set;}
        
        public string Type { get; set;}
        
        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public DateTime TransitionDate { get; set;}
        
        public long Quantity { get; set;}
        
        public IStateReference FromState { get; set;}
        
        public IStateReference ToState { get; set;}
        public CustomLineItemStateTransitionMessage()
        { 
           this.Type = "CustomLineItemStateTransition";
        }
    }
}
