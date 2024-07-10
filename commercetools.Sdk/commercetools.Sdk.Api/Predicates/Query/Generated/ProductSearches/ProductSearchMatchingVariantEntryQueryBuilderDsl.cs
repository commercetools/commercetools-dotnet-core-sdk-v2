using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchMatchingVariantEntryQueryBuilderDsl
    {
        public ProductSearchMatchingVariantEntryQueryBuilderDsl()
        {
        }

        public static ProductSearchMatchingVariantEntryQueryBuilderDsl Of()
        {
            return new ProductSearchMatchingVariantEntryQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchMatchingVariantEntryQueryBuilderDsl, long> Id()
        {
            return new ComparisonPredicateBuilder<ProductSearchMatchingVariantEntryQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductSearchMatchingVariantEntryQueryBuilderDsl>(p, ProductSearchMatchingVariantEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchMatchingVariantEntryQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductSearchMatchingVariantEntryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductSearchMatchingVariantEntryQueryBuilderDsl>(p, ProductSearchMatchingVariantEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
