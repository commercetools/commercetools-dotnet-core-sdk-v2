using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetKeyAction))]
    public partial interface IApprovalRuleSetKeyAction : IApprovalRuleUpdateAction
    {
        string Key { get; set; }

    }
}
