using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

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
        public ICollectionPredicateBuilder<ProductPagedSearchResponseQueryBuilderDsl> Facets()
        {
            return new CollectionPredicateBuilder<ProductPagedSearchResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("facets")),
                    p => new CombinationQueryPredicate<ProductPagedSearchResponseQueryBuilderDsl>(p, ProductPagedSearchResponseQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductPagedSearchResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchResultQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchResultQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPagedSearchResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchResultQueryBuilderDsl.Of())),
                ProductPagedSearchResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductPagedSearchResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ProductPagedSearchResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ProductPagedSearchResponseQueryBuilderDsl>(p, ProductPagedSearchResponseQueryBuilderDsl.Of));
        }

    }
}
