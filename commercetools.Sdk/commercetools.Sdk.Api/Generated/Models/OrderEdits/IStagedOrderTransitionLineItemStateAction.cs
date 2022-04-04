using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.States;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionLineItemStateAction))]
    public partial interface IStagedOrderTransitionLineItemStateAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set; }

        long Quantity { get; set; }

        IStateResourceIdentifier FromState { get; set; }

        IStateResourceIdentifier ToState { get; set; }

        DateTime? ActualTransitionDate { get; set; }
    }
}
