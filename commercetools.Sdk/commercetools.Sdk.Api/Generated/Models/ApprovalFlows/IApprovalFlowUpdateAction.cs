using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalFlows
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowUpdateAction))]
    [SubTypeDiscriminator("approve", typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowApproveAction))]
    [SubTypeDiscriminator("reject", typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowRejectAction))]
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
    }
}
