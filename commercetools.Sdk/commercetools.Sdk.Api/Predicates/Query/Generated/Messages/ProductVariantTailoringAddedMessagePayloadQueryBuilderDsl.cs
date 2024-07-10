using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl
    {
        public ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl>(p, ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl, string> ProductKey()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productKey")),
            p => new CombinationQueryPredicate<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl>(p, ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl>(p, ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl> Variant(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductVariantTailoringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductVariantTailoringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variant"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductVariantTailoringQueryBuilderDsl.Of())),
                ProductVariantTailoringAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
