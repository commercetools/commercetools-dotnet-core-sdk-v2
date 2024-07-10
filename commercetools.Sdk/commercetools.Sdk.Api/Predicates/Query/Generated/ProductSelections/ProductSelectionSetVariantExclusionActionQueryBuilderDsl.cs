using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductSelectionSetVariantExclusionActionQueryBuilderDsl
    {
        public ProductSelectionSetVariantExclusionActionQueryBuilderDsl()
        {
        }

        public static ProductSelectionSetVariantExclusionActionQueryBuilderDsl Of()
        {
            return new ProductSelectionSetVariantExclusionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionSetVariantExclusionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSelectionSetVariantExclusionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSelectionSetVariantExclusionActionQueryBuilderDsl>(p, ProductSelectionSetVariantExclusionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionSetVariantExclusionActionQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionSetVariantExclusionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl.Of())),
                ProductSelectionSetVariantExclusionActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductSelectionSetVariantExclusionActionQueryBuilderDsl> VariantExclusion(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionSetVariantExclusionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variantExclusion"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantExclusionQueryBuilderDsl.Of())),
                ProductSelectionSetVariantExclusionActionQueryBuilderDsl.Of);
        }


    }
}
