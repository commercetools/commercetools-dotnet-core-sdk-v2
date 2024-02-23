// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductVariantExclusionQueryBuilderDsl
    {
        public ProductVariantExclusionQueryBuilderDsl()
        {
        }

        public static ProductVariantExclusionQueryBuilderDsl Of()
        {
            return new ProductVariantExclusionQueryBuilderDsl();
        }

        public IComparableCollectionPredicateBuilder<ProductVariantExclusionQueryBuilderDsl, string> Skus()
        {
            return new ComparableCollectionPredicateBuilder<ProductVariantExclusionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("skus")),
            p => new CombinationQueryPredicate<ProductVariantExclusionQueryBuilderDsl>(p, ProductVariantExclusionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
