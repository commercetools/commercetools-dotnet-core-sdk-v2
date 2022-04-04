using commercetools.Sdk.Api.Models.States;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderTransitionLineItemStateAction))]
    public partial interface IOrderTransitionLineItemStateAction : IOrderUpdateAction
    {
        string LineItemId { get; set; }

        long Quantity { get; set; }

        IStateResourceIdentifier FromState { get; set; }

        IStateResourceIdentifier ToState { get; set; }

        DateTime? ActualTransitionDate { get; set; }
    }
}
