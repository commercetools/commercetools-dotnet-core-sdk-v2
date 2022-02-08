using commercetools.Api.Models.States;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomLineItemStateTransitionMessagePayload))]
    public partial interface ICustomLineItemStateTransitionMessagePayload : IOrderMessagePayload
    {
        string CustomLineItemId { get; set; }

        DateTime TransitionDate { get; set; }

        long Quantity { get; set; }

        IStateReference FromState { get; set; }

        IStateReference ToState { get; set; }
    }
}
