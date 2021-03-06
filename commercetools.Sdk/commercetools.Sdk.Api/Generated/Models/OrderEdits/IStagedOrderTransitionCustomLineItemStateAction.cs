using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderTransitionCustomLineItemStateAction))]
    public partial interface IStagedOrderTransitionCustomLineItemStateAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set;}
        
        long Quantity { get; set;}
        
        IStateResourceIdentifier FromState { get; set;}
        
        IStateResourceIdentifier ToState { get; set;}
        
        DateTime? ActualTransitionDate { get; set;}
    }
}
