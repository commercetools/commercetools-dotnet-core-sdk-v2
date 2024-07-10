using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalRuleCreatedMessagePayloadQueryBuilderDsl
    {
        public ApprovalRuleCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ApprovalRuleCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new ApprovalRuleCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalRuleCreatedMessagePayloadQueryBuilderDsl>(p, ApprovalRuleCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleCreatedMessagePayloadQueryBuilderDsl> ApprovalRule(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("approvalRule"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.ApprovalRuleQueryBuilderDsl.Of())),
                ApprovalRuleCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
