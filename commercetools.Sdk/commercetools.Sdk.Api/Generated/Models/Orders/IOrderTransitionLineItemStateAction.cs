using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderTransitionLineItemStateAction))]
    public partial interface IOrderTransitionLineItemStateAction : IOrderUpdateAction
    {
        string LineItemId { get; set;}
        
        long Quantity { get; set;}
        
        IStateResourceIdentifier FromState { get; set;}
        
        IStateResourceIdentifier ToState { get; set;}
        
        DateTime? ActualTransitionDate { get; set;}
    }
}
