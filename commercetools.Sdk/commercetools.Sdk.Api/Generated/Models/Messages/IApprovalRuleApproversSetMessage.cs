using commercetools.Sdk.Api.Models.ApprovalRules;
using commercetools.Base.CustomAttributes;

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
