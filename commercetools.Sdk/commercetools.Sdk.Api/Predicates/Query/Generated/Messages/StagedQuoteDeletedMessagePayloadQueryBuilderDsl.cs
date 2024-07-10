// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StagedQuoteDeletedMessagePayloadQueryBuilderDsl
    {
        public StagedQuoteDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StagedQuoteDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new StagedQuoteDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StagedQuoteDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StagedQuoteDeletedMessagePayloadQueryBuilderDsl>(p, StagedQuoteDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
