using commercetools.Sdk.Api.Models.ApprovalRules;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleApproversSetMessage))]
    public partial interface IApprovalRuleApproversSetMessage : IMessage
    {
        IApproverHierarchy Approvers { get; set; }

        IApproverHierarchy OldApprovers { get; set; }

    }
}
