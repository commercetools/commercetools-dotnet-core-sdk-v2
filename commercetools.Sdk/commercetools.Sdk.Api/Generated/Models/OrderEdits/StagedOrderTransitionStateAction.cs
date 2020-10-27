using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class StagedOrderTransitionStateAction : IStagedOrderTransitionStateAction
    {
        public string Action { get; set;}
        
        public IStateResourceIdentifier State { get; set;}
        
        public bool? Force { get; set;}
        public StagedOrderTransitionStateAction()
        { 
           this.Action = "transitionState";
        }
    }
}
