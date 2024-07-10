// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPriceModeSetMessagePayloadQueryBuilderDsl
    {
        public ProductPriceModeSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductPriceModeSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductPriceModeSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPriceModeSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductPriceModeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductPriceModeSetMessagePayloadQueryBuilderDsl>(p, ProductPriceModeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceModeSetMessagePayloadQueryBuilderDsl, string> To()
        {
            return new ComparisonPredicateBuilder<ProductPriceModeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("to")),
            p => new CombinationQueryPredicate<ProductPriceModeSetMessagePayloadQueryBuilderDsl>(p, ProductPriceModeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
