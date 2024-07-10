using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductVariantSelectionIncludeAllExceptQueryBuilderDsl
    {
        public ProductVariantSelectionIncludeAllExceptQueryBuilderDsl()
        {
        }

        public static ProductVariantSelectionIncludeAllExceptQueryBuilderDsl Of()
        {
            return new ProductVariantSelectionIncludeAllExceptQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantSelectionIncludeAllExceptQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductVariantSelectionIncludeAllExceptQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductVariantSelectionIncludeAllExceptQueryBuilderDsl>(p, ProductVariantSelectionIncludeAllExceptQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductVariantSelectionIncludeAllExceptQueryBuilderDsl, string> Skus()
        {
            return new ComparableCollectionPredicateBuilder<ProductVariantSelectionIncludeAllExceptQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("skus")),
            p => new CombinationQueryPredicate<ProductVariantSelectionIncludeAllExceptQueryBuilderDsl>(p, ProductVariantSelectionIncludeAllExceptQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
