using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductSelectionAddProductActionQueryBuilderDsl
    {
        public ProductSelectionAddProductActionQueryBuilderDsl()
        {
        }

        public static ProductSelectionAddProductActionQueryBuilderDsl Of()
        {
            return new ProductSelectionAddProductActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionAddProductActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSelectionAddProductActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSelectionAddProductActionQueryBuilderDsl>(p, ProductSelectionAddProductActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionAddProductActionQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionAddProductActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl.Of())),
                ProductSelectionAddProductActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionAddProductActionQueryBuilderDsl> VariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionAddProductActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variantSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl.Of())),
                ProductSelectionAddProductActionQueryBuilderDsl.Of);
        }


    }
}
