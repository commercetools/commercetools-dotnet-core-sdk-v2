using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRulePredicateSetMessagePayload))]
    public partial interface IApprovalRulePredicateSetMessagePayload : IMessagePayload
    {
        string Predicate { get; set; }

        string OldPredicate { get; set; }

    }
}
