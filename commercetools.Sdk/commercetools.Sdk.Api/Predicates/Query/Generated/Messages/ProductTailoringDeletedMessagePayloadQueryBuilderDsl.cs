using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductTailoringDeletedMessagePayloadQueryBuilderDsl
    {
        public ProductTailoringDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductTailoringDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductTailoringDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductTailoringDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductTailoringDeletedMessagePayloadQueryBuilderDsl>(p, ProductTailoringDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringDeletedMessagePayloadQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringDeletedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                ProductTailoringDeletedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringDeletedMessagePayloadQueryBuilderDsl, string> ProductKey()
        {
            return new ComparisonPredicateBuilder<ProductTailoringDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productKey")),
            p => new CombinationQueryPredicate<ProductTailoringDeletedMessagePayloadQueryBuilderDsl>(p, ProductTailoringDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringDeletedMessagePayloadQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringDeletedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                ProductTailoringDeletedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
