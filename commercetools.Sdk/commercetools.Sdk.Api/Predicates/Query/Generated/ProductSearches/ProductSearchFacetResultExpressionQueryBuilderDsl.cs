using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetResultExpressionQueryBuilderDsl
    {
        public ProductSearchFacetResultExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetResultExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchFacetResultExpressionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetResultExpressionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultExpressionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultExpressionQueryBuilderDsl>(p, ProductSearchFacetResultExpressionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProductSearchFacetResultExpressionQueryBuilderDsl> AsProductSearchFacetBucketResult(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetBucketResultQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetBucketResultQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetResultExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetBucketResultQueryBuilderDsl.Of()),
                ProductSearchFacetResultExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchFacetResultExpressionQueryBuilderDsl> AsProductSearchFacetResultCount(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultCountQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultCountQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetResultExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultCountQueryBuilderDsl.Of()),
                ProductSearchFacetResultExpressionQueryBuilderDsl.Of);
        }
    }
}
