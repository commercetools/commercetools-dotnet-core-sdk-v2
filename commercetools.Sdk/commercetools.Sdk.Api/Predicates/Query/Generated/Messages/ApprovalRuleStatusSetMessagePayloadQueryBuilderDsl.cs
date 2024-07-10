using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl
    {
        public ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl, string> OldStatus()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldStatus")),
            p => new CombinationQueryPredicate<ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleStatusSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
