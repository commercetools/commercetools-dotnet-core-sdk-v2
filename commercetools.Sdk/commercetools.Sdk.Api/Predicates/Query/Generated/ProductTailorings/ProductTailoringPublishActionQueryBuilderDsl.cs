// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringPublishActionQueryBuilderDsl
    {
        public ProductTailoringPublishActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringPublishActionQueryBuilderDsl Of()
        {
            return new ProductTailoringPublishActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringPublishActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringPublishActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringPublishActionQueryBuilderDsl>(p, ProductTailoringPublishActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
