using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductSelectionAssignmentQueryBuilderDsl
    {
        public ProductSelectionAssignmentQueryBuilderDsl()
        {
        }

        public static ProductSelectionAssignmentQueryBuilderDsl Of()
        {
            return new ProductSelectionAssignmentQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSelectionAssignmentQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionAssignmentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                ProductSelectionAssignmentQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionAssignmentQueryBuilderDsl> ProductSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionAssignmentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionReferenceQueryBuilderDsl.Of())),
                ProductSelectionAssignmentQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionAssignmentQueryBuilderDsl> VariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionAssignmentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variantSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl.Of())),
                ProductSelectionAssignmentQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionAssignmentQueryBuilderDsl> VariantExclusion(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionAssignmentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variantExclusion"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl.Of())),
                ProductSelectionAssignmentQueryBuilderDsl.Of);
        }


    }
}
