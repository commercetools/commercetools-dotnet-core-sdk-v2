// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetPriceModeActionQueryBuilderDsl
    {
        public ProductSetPriceModeActionQueryBuilderDsl()
        {
        }

        public static ProductSetPriceModeActionQueryBuilderDsl Of()
        {
            return new ProductSetPriceModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetPriceModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetPriceModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetPriceModeActionQueryBuilderDsl>(p, ProductSetPriceModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetPriceModeActionQueryBuilderDsl, string> PriceMode()
        {
            return new ComparisonPredicateBuilder<ProductSetPriceModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceMode")),
            p => new CombinationQueryPredicate<ProductSetPriceModeActionQueryBuilderDsl>(p, ProductSetPriceModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
