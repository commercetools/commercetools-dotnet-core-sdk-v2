using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetNameAction))]
    public partial interface IApprovalRuleSetNameAction : IApprovalRuleUpdateAction
    {
        string Name { get; set; }

    }
}
