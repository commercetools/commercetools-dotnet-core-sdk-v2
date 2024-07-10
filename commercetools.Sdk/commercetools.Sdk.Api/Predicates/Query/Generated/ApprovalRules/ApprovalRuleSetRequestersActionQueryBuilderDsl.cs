using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApprovalRuleSetRequestersActionQueryBuilderDsl
    {
        public ApprovalRuleSetRequestersActionQueryBuilderDsl()
        {
        }

        public static ApprovalRuleSetRequestersActionQueryBuilderDsl Of()
        {
            return new ApprovalRuleSetRequestersActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleSetRequestersActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleSetRequestersActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ApprovalRuleSetRequestersActionQueryBuilderDsl>(p, ApprovalRuleSetRequestersActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalRuleSetRequestersActionQueryBuilderDsl> Requesters(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalRuleSetRequestersActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("requesters"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalRules.RuleRequesterDraftQueryBuilderDsl.Of())),
                ApprovalRuleSetRequestersActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalRuleSetRequestersActionQueryBuilderDsl> Requesters()
        {
            return new CollectionPredicateBuilder<ApprovalRuleSetRequestersActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("requesters")),
                    p => new CombinationQueryPredicate<ApprovalRuleSetRequestersActionQueryBuilderDsl>(p, ApprovalRuleSetRequestersActionQueryBuilderDsl.Of));
        }

    }
}
