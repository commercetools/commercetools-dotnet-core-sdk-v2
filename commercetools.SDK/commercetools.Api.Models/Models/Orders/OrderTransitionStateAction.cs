using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("transitionState")]
    public class OrderTransitionStateAction : OrderUpdateAction
    {
        public StateResourceIdentifier State { get; set;}
        
        public bool Force { get; set;}
    }
}
