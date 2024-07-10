using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class FacetRangeQueryBuilderDsl
    {
        public FacetRangeQueryBuilderDsl()
        {
        }

        public static FacetRangeQueryBuilderDsl Of()
        {
            return new FacetRangeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, decimal> From()
        {
            return new ComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("from")),
            p => new CombinationQueryPredicate<FacetRangeQueryBuilderDsl>(p, FacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, string> FromStr()
        {
            return new ComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fromStr")),
            p => new CombinationQueryPredicate<FacetRangeQueryBuilderDsl>(p, FacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, decimal> To()
        {
            return new ComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("to")),
            p => new CombinationQueryPredicate<FacetRangeQueryBuilderDsl>(p, FacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, string> ToStr()
        {
            return new ComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("toStr")),
            p => new CombinationQueryPredicate<FacetRangeQueryBuilderDsl>(p, FacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<FacetRangeQueryBuilderDsl>(p, FacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, long> ProductCount()
        {
            return new ComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productCount")),
            p => new CombinationQueryPredicate<FacetRangeQueryBuilderDsl>(p, FacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, decimal> Total()
        {
            return new ComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<FacetRangeQueryBuilderDsl>(p, FacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, decimal> Min()
        {
            return new ComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("min")),
            p => new CombinationQueryPredicate<FacetRangeQueryBuilderDsl>(p, FacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, decimal> Max()
        {
            return new ComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("max")),
            p => new CombinationQueryPredicate<FacetRangeQueryBuilderDsl>(p, FacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, decimal> Mean()
        {
            return new ComparisonPredicateBuilder<FacetRangeQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mean")),
            p => new CombinationQueryPredicate<FacetRangeQueryBuilderDsl>(p, FacetRangeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
