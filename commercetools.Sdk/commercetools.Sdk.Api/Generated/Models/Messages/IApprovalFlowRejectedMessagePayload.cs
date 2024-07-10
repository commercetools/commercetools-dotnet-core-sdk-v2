using commercetools.Sdk.Api.Models.Customers;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalFlowRejectedMessagePayload))]
    public partial interface IApprovalFlowRejectedMessagePayload : IMessagePayload
    {
        ICustomerReference Associate { get; set; }

        string RejectionReason { get; set; }

        IOrderReference Order { get; set; }

    }
}
