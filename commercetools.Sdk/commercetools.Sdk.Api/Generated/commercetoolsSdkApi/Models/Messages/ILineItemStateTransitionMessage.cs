using commercetools.Sdk.Api.Models.States;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.LineItemStateTransitionMessage))]
    public partial interface ILineItemStateTransitionMessage : IOrderMessage
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        DateTime TransitionDate { get; set; }

        long Quantity { get; set; }

        IStateReference FromState { get; set; }

        IStateReference ToState { get; set; }

    }
}
