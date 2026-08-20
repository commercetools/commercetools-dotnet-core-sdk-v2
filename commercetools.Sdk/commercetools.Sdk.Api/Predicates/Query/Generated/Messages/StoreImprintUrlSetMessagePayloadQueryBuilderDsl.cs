// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreImprintUrlSetMessagePayloadQueryBuilderDsl
    {
        public StoreImprintUrlSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreImprintUrlSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreImprintUrlSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreImprintUrlSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreImprintUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreImprintUrlSetMessagePayloadQueryBuilderDsl>(p, StoreImprintUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreImprintUrlSetMessagePayloadQueryBuilderDsl, string> ImprintUrl()
        {
            return new ComparisonPredicateBuilder<StoreImprintUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("imprintUrl")),
            p => new CombinationQueryPredicate<StoreImprintUrlSetMessagePayloadQueryBuilderDsl>(p, StoreImprintUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
