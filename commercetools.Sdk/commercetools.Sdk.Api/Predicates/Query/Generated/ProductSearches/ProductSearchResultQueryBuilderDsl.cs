using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchResultQueryBuilderDsl
    {
        public ProductSearchResultQueryBuilderDsl()
        {
        }

        public static ProductSearchResultQueryBuilderDsl Of()
        {
            return new ProductSearchResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchResultQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductSearchResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductSearchResultQueryBuilderDsl>(p, ProductSearchResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchResultQueryBuilderDsl> MatchingVariants(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchMatchingVariantsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchMatchingVariantsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchResultQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("matchingVariants"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchMatchingVariantsQueryBuilderDsl.Of())),
                ProductSearchResultQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSearchResultQueryBuilderDsl> ProductProjection(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchResultQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productProjection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl.Of())),
                ProductSearchResultQueryBuilderDsl.Of);
        }


    }
}
