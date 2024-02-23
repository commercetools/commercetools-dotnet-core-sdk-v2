using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductProjectionPagedSearchResponseQueryBuilderDsl
    {
        public ProductProjectionPagedSearchResponseQueryBuilderDsl()
        {
        }

        public static ProductProjectionPagedSearchResponseQueryBuilderDsl Of()
        {
            return new ProductProjectionPagedSearchResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductProjectionPagedSearchResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ProductProjectionPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ProductProjectionPagedSearchResponseQueryBuilderDsl>(p, ProductProjectionPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductProjectionPagedSearchResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ProductProjectionPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ProductProjectionPagedSearchResponseQueryBuilderDsl>(p, ProductProjectionPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductProjectionPagedSearchResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ProductProjectionPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ProductProjectionPagedSearchResponseQueryBuilderDsl>(p, ProductProjectionPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductProjectionPagedSearchResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ProductProjectionPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ProductProjectionPagedSearchResponseQueryBuilderDsl>(p, ProductProjectionPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductProjectionPagedSearchResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionPagedSearchResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl.Of())),
                ProductProjectionPagedSearchResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductProjectionPagedSearchResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ProductProjectionPagedSearchResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ProductProjectionPagedSearchResponseQueryBuilderDsl>(p, ProductProjectionPagedSearchResponseQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductProjectionPagedSearchResponseQueryBuilderDsl> Facets(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.FacetResultsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.FacetResultsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionPagedSearchResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("facets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.FacetResultsQueryBuilderDsl.Of())),
                ProductProjectionPagedSearchResponseQueryBuilderDsl.Of);
        }


    }
}
