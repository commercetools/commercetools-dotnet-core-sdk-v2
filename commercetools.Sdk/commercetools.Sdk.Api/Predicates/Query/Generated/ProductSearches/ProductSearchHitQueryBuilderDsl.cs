using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchHitQueryBuilderDsl
    {
        public ProductSearchHitQueryBuilderDsl()
        {
        }

        public static ProductSearchHitQueryBuilderDsl Of()
        {
            return new ProductSearchHitQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchHitQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductSearchHitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductSearchHitQueryBuilderDsl>(p, ProductSearchHitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchHitQueryBuilderDsl> ProductProjection(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchHitQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productProjection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl.Of())),
                ProductSearchHitQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSearchHitQueryBuilderDsl> MatchingVariants(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchMatchingVariantQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchMatchingVariantQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchHitQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("matchingVariants"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchMatchingVariantQueryBuilderDsl.Of())),
                ProductSearchHitQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchHitQueryBuilderDsl> MatchingVariants()
        {
            return new CollectionPredicateBuilder<ProductSearchHitQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("matchingVariants")),
                    p => new CombinationQueryPredicate<ProductSearchHitQueryBuilderDsl>(p, ProductSearchHitQueryBuilderDsl.Of));
        }

    }
}
