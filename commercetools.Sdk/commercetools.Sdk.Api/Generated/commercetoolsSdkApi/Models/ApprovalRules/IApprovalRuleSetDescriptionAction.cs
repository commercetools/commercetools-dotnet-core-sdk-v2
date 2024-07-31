using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetDescriptionAction))]
    public partial interface IApprovalRuleSetDescriptionAction : IApprovalRuleUpdateAction
    {
        string Description { get; set; }

    }
}
