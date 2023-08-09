// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductRemovePriceActionQueryBuilderDsl
    {
        public ProductRemovePriceActionQueryBuilderDsl()
        {
        }

        public static ProductRemovePriceActionQueryBuilderDsl Of()
        {
            return new ProductRemovePriceActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductRemovePriceActionQueryBuilderDsl>(p, ProductRemovePriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductRemovePriceActionQueryBuilderDsl>(p, ProductRemovePriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductRemovePriceActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductRemovePriceActionQueryBuilderDsl>(p, ProductRemovePriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
