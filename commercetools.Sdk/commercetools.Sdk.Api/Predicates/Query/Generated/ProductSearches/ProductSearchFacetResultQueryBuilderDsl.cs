using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetResultQueryBuilderDsl
    {
        public ProductSearchFacetResultQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetResultQueryBuilderDsl Of()
        {
            return new ProductSearchFacetResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetResultQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultQueryBuilderDsl>(p, ProductSearchFacetResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProductSearchFacetResultQueryBuilderDsl> AsProductSearchFacetResultBucket(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultBucketQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultBucketQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetResultQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultBucketQueryBuilderDsl.Of()),
                ProductSearchFacetResultQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchFacetResultQueryBuilderDsl> AsProductSearchFacetResultCount(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultCountQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultCountQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetResultQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultCountQueryBuilderDsl.Of()),
                ProductSearchFacetResultQueryBuilderDsl.Of);
        }
    }
}
