using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleSetPredicateAction))]
    public partial interface IApprovalRuleSetPredicateAction : IApprovalRuleUpdateAction
    {
        string Predicate { get; set; }

    }
}
