// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceDeletedMessagePayloadQueryBuilderDsl
    {
        public StandalonePriceDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StandalonePriceDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new StandalonePriceDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceDeletedMessagePayloadQueryBuilderDsl>(p, StandalonePriceDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
