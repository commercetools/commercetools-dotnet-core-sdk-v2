using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl
    {
        public ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl>(p, ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl> OldVariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldVariantSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl.Of())),
                ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl> NewVariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newVariantSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl.Of())),
                ProductSelectionVariantSelectionChangedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
