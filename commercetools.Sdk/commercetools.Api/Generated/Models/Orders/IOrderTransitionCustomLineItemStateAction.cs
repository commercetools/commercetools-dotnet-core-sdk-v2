using commercetools.Api.Generated.Models.Orders;
using commercetools.Api.Generated.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IOrderTransitionCustomLineItemStateAction : IOrderUpdateAction
    {
        string CustomLineItemId { get; set;}
        
        long Quantity { get; set;}
        
        IStateResourceIdentifier FromState { get; set;}
        
        IStateResourceIdentifier ToState { get; set;}
        
        DateTime ActualTransitionDate { get; set;}
    }
}
