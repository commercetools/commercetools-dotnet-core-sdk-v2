using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetApproversAction))]
    public partial interface IApprovalRuleSetApproversAction : IApprovalRuleUpdateAction
    {
        IApproverHierarchyDraft Approvers { get; set; }

    }
}
