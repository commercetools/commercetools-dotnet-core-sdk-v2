using commercetools.Sdk.Api.Models.States;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomLineItemStateTransitionMessage))]
    public partial interface ICustomLineItemStateTransitionMessage : IOrderMessage
    {
        string CustomLineItemId { get; set; }

        string CustomLineItemKey { get; set; }

        DateTime TransitionDate { get; set; }

        long Quantity { get; set; }

        IStateReference FromState { get; set; }

        IStateReference ToState { get; set; }

    }
}
