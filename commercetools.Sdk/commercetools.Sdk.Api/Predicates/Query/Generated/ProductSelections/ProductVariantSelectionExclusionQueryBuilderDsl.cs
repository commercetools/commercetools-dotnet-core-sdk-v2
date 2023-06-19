using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    [Obsolete]
    public partial class ProductVariantSelectionExclusionQueryBuilderDsl
    {
        public ProductVariantSelectionExclusionQueryBuilderDsl()
        {
        }

        public static ProductVariantSelectionExclusionQueryBuilderDsl Of()
        {
            return new ProductVariantSelectionExclusionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantSelectionExclusionQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductVariantSelectionExclusionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductVariantSelectionExclusionQueryBuilderDsl>(p, ProductVariantSelectionExclusionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductVariantSelectionExclusionQueryBuilderDsl, string> Skus()
        {
            return new ComparableCollectionPredicateBuilder<ProductVariantSelectionExclusionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("skus")),
            p => new CombinationQueryPredicate<ProductVariantSelectionExclusionQueryBuilderDsl>(p, ProductVariantSelectionExclusionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
