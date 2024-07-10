using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl
    {
        public ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl>(p, ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl>(p, ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl, string> OldPredicate()
        {
            return new ComparisonPredicateBuilder<ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldPredicate")),
            p => new CombinationQueryPredicate<ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl>(p, ApprovalRulePredicateSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
