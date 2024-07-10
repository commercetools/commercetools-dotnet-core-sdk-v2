using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalRuleNameSetMessagePayloadQueryBuilderDsl
    {
        public ApprovalRuleNameSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ApprovalRuleNameSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ApprovalRuleNameSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleNameSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleNameSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalRuleNameSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleNameSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleNameSetMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleNameSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ApprovalRuleNameSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleNameSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleNameSetMessagePayloadQueryBuilderDsl, string> OldName()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleNameSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldName")),
            p => new CombinationQueryPredicate<ApprovalRuleNameSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleNameSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
