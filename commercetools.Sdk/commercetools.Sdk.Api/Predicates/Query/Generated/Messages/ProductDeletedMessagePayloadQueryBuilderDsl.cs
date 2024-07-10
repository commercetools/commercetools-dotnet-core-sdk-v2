using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductDeletedMessagePayloadQueryBuilderDsl
    {
        public ProductDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductDeletedMessagePayloadQueryBuilderDsl>(p, ProductDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductDeletedMessagePayloadQueryBuilderDsl, string> RemovedImageUrls()
        {
            return new ComparableCollectionPredicateBuilder<ProductDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedImageUrls")),
            p => new CombinationQueryPredicate<ProductDeletedMessagePayloadQueryBuilderDsl>(p, ProductDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDeletedMessagePayloadQueryBuilderDsl> CurrentProjection(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDeletedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("currentProjection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductProjectionQueryBuilderDsl.Of())),
                ProductDeletedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
