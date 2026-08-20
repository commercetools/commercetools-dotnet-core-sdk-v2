// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreContactUrlSetMessagePayloadQueryBuilderDsl
    {
        public StoreContactUrlSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreContactUrlSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreContactUrlSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreContactUrlSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreContactUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreContactUrlSetMessagePayloadQueryBuilderDsl>(p, StoreContactUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreContactUrlSetMessagePayloadQueryBuilderDsl, string> ContactUrl()
        {
            return new ComparisonPredicateBuilder<StoreContactUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactUrl")),
            p => new CombinationQueryPredicate<StoreContactUrlSetMessagePayloadQueryBuilderDsl>(p, StoreContactUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
