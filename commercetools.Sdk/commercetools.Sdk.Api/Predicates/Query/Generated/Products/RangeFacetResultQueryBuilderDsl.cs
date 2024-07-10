using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class RangeFacetResultQueryBuilderDsl
    {
        public RangeFacetResultQueryBuilderDsl()
        {
        }

        public static RangeFacetResultQueryBuilderDsl Of()
        {
            return new RangeFacetResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RangeFacetResultQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RangeFacetResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RangeFacetResultQueryBuilderDsl>(p, RangeFacetResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RangeFacetResultQueryBuilderDsl> Ranges(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.FacetRangeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.FacetRangeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RangeFacetResultQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("ranges"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.FacetRangeQueryBuilderDsl.Of())),
                RangeFacetResultQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<RangeFacetResultQueryBuilderDsl> Ranges()
        {
            return new CollectionPredicateBuilder<RangeFacetResultQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("ranges")),
                    p => new CombinationQueryPredicate<RangeFacetResultQueryBuilderDsl>(p, RangeFacetResultQueryBuilderDsl.Of));
        }

    }
}
