using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalFlows
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowUpdateAction))]
    [SubTypeDiscriminator("approve", typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowApproveAction))]
    [SubTypeDiscriminator("reject", typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowRejectAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowSetCustomTypeAction))]
    public partial interface IApprovalFlowUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowApproveAction Approve(Action<commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowApproveAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowApproveAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowRejectAction Reject(Action<commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowRejectAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowRejectAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
    }
}
