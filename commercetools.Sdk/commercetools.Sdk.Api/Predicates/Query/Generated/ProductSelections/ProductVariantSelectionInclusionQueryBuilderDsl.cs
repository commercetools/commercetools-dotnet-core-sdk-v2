using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    [Obsolete]
    public partial class ProductVariantSelectionInclusionQueryBuilderDsl
    {
        public ProductVariantSelectionInclusionQueryBuilderDsl()
        {
        }

        public static ProductVariantSelectionInclusionQueryBuilderDsl Of()
        {
            return new ProductVariantSelectionInclusionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantSelectionInclusionQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductVariantSelectionInclusionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductVariantSelectionInclusionQueryBuilderDsl>(p, ProductVariantSelectionInclusionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductVariantSelectionInclusionQueryBuilderDsl, string> Skus()
        {
            return new ComparableCollectionPredicateBuilder<ProductVariantSelectionInclusionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("skus")),
            p => new CombinationQueryPredicate<ProductVariantSelectionInclusionQueryBuilderDsl>(p, ProductVariantSelectionInclusionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
