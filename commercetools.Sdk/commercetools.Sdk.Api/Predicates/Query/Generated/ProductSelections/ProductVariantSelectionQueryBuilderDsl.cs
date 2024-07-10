using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductVariantSelectionQueryBuilderDsl
    {
        public ProductVariantSelectionQueryBuilderDsl()
        {
        }

        public static ProductVariantSelectionQueryBuilderDsl Of()
        {
            return new ProductVariantSelectionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantSelectionQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductVariantSelectionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductVariantSelectionQueryBuilderDsl>(p, ProductVariantSelectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProductVariantSelectionQueryBuilderDsl> AsIncludeAllExcept(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionIncludeAllExceptQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionIncludeAllExceptQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantSelectionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionIncludeAllExceptQueryBuilderDsl.Of()),
                ProductVariantSelectionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductVariantSelectionQueryBuilderDsl> AsIncludeOnly(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionIncludeOnlyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionIncludeOnlyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantSelectionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductVariantSelectionIncludeOnlyQueryBuilderDsl.Of()),
                ProductVariantSelectionQueryBuilderDsl.Of);
        }
    }
}
