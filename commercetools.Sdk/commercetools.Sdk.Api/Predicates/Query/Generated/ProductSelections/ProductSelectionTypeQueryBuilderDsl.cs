using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    [Obsolete]
    public partial class ProductSelectionTypeQueryBuilderDsl
    {
        public ProductSelectionTypeQueryBuilderDsl()
        {
        }

        public static ProductSelectionTypeQueryBuilderDsl Of()
        {
            return new ProductSelectionTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionTypeQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductSelectionTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductSelectionTypeQueryBuilderDsl>(p, ProductSelectionTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProductSelectionTypeQueryBuilderDsl> AsIndividualExclusion(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.IndividualExclusionProductSelectionTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.IndividualExclusionProductSelectionTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.IndividualExclusionProductSelectionTypeQueryBuilderDsl.Of()),
                ProductSelectionTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSelectionTypeQueryBuilderDsl> AsIndividual(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.IndividualProductSelectionTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.IndividualProductSelectionTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.IndividualProductSelectionTypeQueryBuilderDsl.Of()),
                ProductSelectionTypeQueryBuilderDsl.Of);
        }
    }
}
