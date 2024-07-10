using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class FacetResultQueryBuilderDsl
    {
        public FacetResultQueryBuilderDsl()
        {
        }

        public static FacetResultQueryBuilderDsl Of()
        {
            return new FacetResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<FacetResultQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<FacetResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<FacetResultQueryBuilderDsl>(p, FacetResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<FacetResultQueryBuilderDsl> AsFilter(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.FilteredFacetResultQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.FilteredFacetResultQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FacetResultQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.FilteredFacetResultQueryBuilderDsl.Of()),
                FacetResultQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FacetResultQueryBuilderDsl> AsRange(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.RangeFacetResultQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.RangeFacetResultQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FacetResultQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.RangeFacetResultQueryBuilderDsl.Of()),
                FacetResultQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FacetResultQueryBuilderDsl> AsTerms(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.TermFacetResultQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.TermFacetResultQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FacetResultQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.TermFacetResultQueryBuilderDsl.Of()),
                FacetResultQueryBuilderDsl.Of);
        }
    }
}
