// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreOrderUrlTemplateSetMessagePayloadQueryBuilderDsl
    {
        public StoreOrderUrlTemplateSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreOrderUrlTemplateSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreOrderUrlTemplateSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreOrderUrlTemplateSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreOrderUrlTemplateSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreOrderUrlTemplateSetMessagePayloadQueryBuilderDsl>(p, StoreOrderUrlTemplateSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreOrderUrlTemplateSetMessagePayloadQueryBuilderDsl, string> OrderUrlTemplate()
        {
            return new ComparisonPredicateBuilder<StoreOrderUrlTemplateSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderUrlTemplate")),
            p => new CombinationQueryPredicate<StoreOrderUrlTemplateSetMessagePayloadQueryBuilderDsl>(p, StoreOrderUrlTemplateSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
