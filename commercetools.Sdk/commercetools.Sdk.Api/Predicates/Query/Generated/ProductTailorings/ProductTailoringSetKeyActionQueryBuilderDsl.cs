// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetKeyActionQueryBuilderDsl
    {
        public ProductTailoringSetKeyActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetKeyActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetKeyActionQueryBuilderDsl>(p, ProductTailoringSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductTailoringSetKeyActionQueryBuilderDsl>(p, ProductTailoringSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
