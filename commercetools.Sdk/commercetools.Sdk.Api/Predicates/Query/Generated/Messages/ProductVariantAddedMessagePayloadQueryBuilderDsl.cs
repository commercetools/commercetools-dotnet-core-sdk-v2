using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductVariantAddedMessagePayloadQueryBuilderDsl
    {
        public ProductVariantAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductVariantAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductVariantAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductVariantAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductVariantAddedMessagePayloadQueryBuilderDsl>(p, ProductVariantAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantAddedMessagePayloadQueryBuilderDsl> Variant(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variant"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl.Of())),
                ProductVariantAddedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductVariantAddedMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductVariantAddedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductVariantAddedMessagePayloadQueryBuilderDsl>(p, ProductVariantAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
