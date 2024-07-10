using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApprovalRuleSetStatusActionQueryBuilderDsl
    {
        public ApprovalRuleSetStatusActionQueryBuilderDsl()
        {
        }

        public static ApprovalRuleSetStatusActionQueryBuilderDsl Of()
        {
            return new ApprovalRuleSetStatusActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleSetStatusActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleSetStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ApprovalRuleSetStatusActionQueryBuilderDsl>(p, ApprovalRuleSetStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleSetStatusActionQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleSetStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<ApprovalRuleSetStatusActionQueryBuilderDsl>(p, ApprovalRuleSetStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
