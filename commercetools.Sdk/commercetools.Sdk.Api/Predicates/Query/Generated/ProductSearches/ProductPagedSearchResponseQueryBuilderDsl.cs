using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductPagedSearchResponseQueryBuilderDsl
    {
        public ProductPagedSearchResponseQueryBuilderDsl()
        {
        }

        public static ProductPagedSearchResponseQueryBuilderDsl Of()
        {
            return new ProductPagedSearchResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPagedSearchResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ProductPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ProductPagedSearchResponseQueryBuilderDsl>(p, ProductPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPagedSearchResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ProductPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ProductPagedSearchResponseQueryBuilderDsl>(p, ProductPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPagedSearchResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ProductPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ProductPagedSearchResponseQueryBuilderDsl>(p, ProductPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPagedSearchResponseQueryBuilderDsl> Facets(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPagedSearchResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("facets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultQueryBuilderDsl.Of())),
                ProductPagedSearchResponseQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductPagedSearchResponseQueryBuilderDsl> Hits(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchHitQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchHitQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPagedSearchResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("hits"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchHitQueryBuilderDsl.Of())),
                ProductPagedSearchResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductPagedSearchResponseQueryBuilderDsl> Hits()
        {
            return new CollectionPredicateBuilder<ProductPagedSearchResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("hits")),
                    p => new CombinationQueryPredicate<ProductPagedSearchResponseQueryBuilderDsl>(p, ProductPagedSearchResponseQueryBuilderDsl.Of));
        }

    }
}
