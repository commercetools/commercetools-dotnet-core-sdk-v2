using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRulePredicateSetMessage))]
    public partial interface IApprovalRulePredicateSetMessage : IMessage
    {
        string Predicate { get; set; }

        string OldPredicate { get; set; }

    }
}
