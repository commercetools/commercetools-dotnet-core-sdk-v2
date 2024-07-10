using commercetools.Sdk.Api.Models.ApprovalFlows;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalFlowCompletedMessagePayload))]
    public partial interface IApprovalFlowCompletedMessagePayload : IMessagePayload
    {
        IApprovalFlowStatus Status { get; set; }

        IOrderReference Order { get; set; }

    }
}
