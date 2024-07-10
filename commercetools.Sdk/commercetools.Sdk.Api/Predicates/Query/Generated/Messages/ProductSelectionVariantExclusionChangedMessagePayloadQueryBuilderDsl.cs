using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl
    {
        public ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl>(p, ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl> OldVariantExclusion(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldVariantExclusion"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl.Of())),
                ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl> NewVariantExclusion(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newVariantExclusion"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl.Of())),
                ProductSelectionVariantExclusionChangedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
