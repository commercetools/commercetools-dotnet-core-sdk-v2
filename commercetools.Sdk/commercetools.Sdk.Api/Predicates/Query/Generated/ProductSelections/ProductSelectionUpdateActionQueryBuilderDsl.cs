using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductSelectionUpdateActionQueryBuilderDsl
    {
        public ProductSelectionUpdateActionQueryBuilderDsl()
        {
        }

        public static ProductSelectionUpdateActionQueryBuilderDsl Of()
        {
            return new ProductSelectionUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSelectionUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl>(p, ProductSelectionUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl> AsAddProduct(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionAddProductActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionAddProductActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionAddProductActionQueryBuilderDsl.Of()),
                ProductSelectionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionChangeNameActionQueryBuilderDsl.Of()),
                ProductSelectionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl> AsExcludeProduct(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionExcludeProductActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionExcludeProductActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionExcludeProductActionQueryBuilderDsl.Of()),
                ProductSelectionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl> AsRemoveProduct(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionRemoveProductActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionRemoveProductActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionRemoveProductActionQueryBuilderDsl.Of()),
                ProductSelectionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetCustomFieldActionQueryBuilderDsl.Of()),
                ProductSelectionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetCustomTypeActionQueryBuilderDsl.Of()),
                ProductSelectionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetKeyActionQueryBuilderDsl.Of()),
                ProductSelectionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl> AsSetVariantExclusion(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetVariantExclusionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetVariantExclusionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetVariantExclusionActionQueryBuilderDsl.Of()),
                ProductSelectionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl> AsSetVariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetVariantSelectionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetVariantSelectionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionSetVariantSelectionActionQueryBuilderDsl.Of()),
                ProductSelectionUpdateActionQueryBuilderDsl.Of);
        }
    }
}
