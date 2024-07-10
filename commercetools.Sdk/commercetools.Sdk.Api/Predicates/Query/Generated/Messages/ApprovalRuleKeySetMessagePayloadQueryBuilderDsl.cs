// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalRuleKeySetMessagePayloadQueryBuilderDsl
    {
        public ApprovalRuleKeySetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ApprovalRuleKeySetMessagePayloadQueryBuilderDsl Of()
        {
            return new ApprovalRuleKeySetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleKeySetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalRuleKeySetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleKeySetMessagePayloadQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ApprovalRuleKeySetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleKeySetMessagePayloadQueryBuilderDsl, string> OldKey()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldKey")),
            p => new CombinationQueryPredicate<ApprovalRuleKeySetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
