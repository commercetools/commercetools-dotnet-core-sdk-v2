using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class AssignedProductReferenceQueryBuilderDsl
    {
        public AssignedProductReferenceQueryBuilderDsl()
        {
        }

        public static AssignedProductReferenceQueryBuilderDsl Of()
        {
            return new AssignedProductReferenceQueryBuilderDsl();
        }

        public CombinationQueryPredicate<AssignedProductReferenceQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssignedProductReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                AssignedProductReferenceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssignedProductReferenceQueryBuilderDsl> VariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssignedProductReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variantSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionQueryBuilderDsl.Of())),
                AssignedProductReferenceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssignedProductReferenceQueryBuilderDsl> VariantExclusion(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssignedProductReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variantExclusion"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl.Of())),
                AssignedProductReferenceQueryBuilderDsl.Of);
        }


    }
}
