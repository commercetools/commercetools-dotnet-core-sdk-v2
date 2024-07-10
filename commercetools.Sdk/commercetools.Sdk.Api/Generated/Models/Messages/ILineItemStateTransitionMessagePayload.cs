using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.LineItemStateTransitionMessagePayload))]
    public partial interface ILineItemStateTransitionMessagePayload : IOrderMessagePayload
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        DateTime TransitionDate { get; set; }

        long Quantity { get; set; }

        IStateReference FromState { get; set; }

        IStateReference ToState { get; set; }

    }
}
