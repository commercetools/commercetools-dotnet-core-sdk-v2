using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderTransitionLineItemStateAction : IOrderTransitionLineItemStateAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public long Quantity { get; set;}
        
        public IStateResourceIdentifier FromState { get; set;}
        
        public IStateResourceIdentifier ToState { get; set;}
        
        public DateTime? ActualTransitionDate { get; set;}
        public OrderTransitionLineItemStateAction()
        { 
           this.Action = "transitionLineItemState";
        }
    }
}
