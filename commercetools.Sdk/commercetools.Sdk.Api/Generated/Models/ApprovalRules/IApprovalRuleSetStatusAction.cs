using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetStatusAction))]
    public partial interface IApprovalRuleSetStatusAction : IApprovalRuleUpdateAction
    {
        IApprovalRuleStatus Status { get; set; }

    }
}
