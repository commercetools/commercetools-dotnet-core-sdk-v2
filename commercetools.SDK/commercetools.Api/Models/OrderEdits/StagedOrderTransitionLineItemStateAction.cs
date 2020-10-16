using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("transitionLineItemState")]
    public partial class StagedOrderTransitionLineItemStateAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public long Quantity { get; set;}
        
        public StateResourceIdentifier FromState { get; set;}
        
        public StateResourceIdentifier ToState { get; set;}
        
        public DateTime ActualTransitionDate { get; set;}
        public StagedOrderTransitionLineItemStateAction()
        { 
           this.Action = "transitionLineItemState";
        }
    }
}
