using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductTailoringPublishedMessagePayloadQueryBuilderDsl
    {
        public ProductTailoringPublishedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductTailoringPublishedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductTailoringPublishedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringPublishedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductTailoringPublishedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductTailoringPublishedMessagePayloadQueryBuilderDsl>(p, ProductTailoringPublishedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringPublishedMessagePayloadQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringPublishedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                ProductTailoringPublishedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringPublishedMessagePayloadQueryBuilderDsl, string> ProductKey()
        {
            return new ComparisonPredicateBuilder<ProductTailoringPublishedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productKey")),
            p => new CombinationQueryPredicate<ProductTailoringPublishedMessagePayloadQueryBuilderDsl>(p, ProductTailoringPublishedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringPublishedMessagePayloadQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringPublishedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                ProductTailoringPublishedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
