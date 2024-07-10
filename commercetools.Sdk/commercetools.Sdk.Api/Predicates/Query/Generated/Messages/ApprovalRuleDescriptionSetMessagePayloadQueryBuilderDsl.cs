// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl
    {
        public ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl, string> OldDescription()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldDescription")),
            p => new CombinationQueryPredicate<ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl>(p, ApprovalRuleDescriptionSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
