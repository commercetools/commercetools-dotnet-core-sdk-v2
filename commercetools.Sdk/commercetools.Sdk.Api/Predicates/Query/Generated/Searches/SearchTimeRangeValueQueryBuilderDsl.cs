using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchTimeRangeValueQueryBuilderDsl
    {
        public SearchTimeRangeValueQueryBuilderDsl()
        {
        }

        public static SearchTimeRangeValueQueryBuilderDsl Of()
        {
            return new SearchTimeRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<SearchTimeRangeValueQueryBuilderDsl>(p, SearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, decimal> Boost()
        {
            return new ComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<SearchTimeRangeValueQueryBuilderDsl>(p, SearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, string> FieldType()
        {
            return new ComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldType")),
            p => new CombinationQueryPredicate<SearchTimeRangeValueQueryBuilderDsl>(p, SearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, TimeSpan> Gte()
        {
            return new ComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, TimeSpan>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<SearchTimeRangeValueQueryBuilderDsl>(p, SearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, TimeSpan> Gt()
        {
            return new ComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, TimeSpan>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gt")),
            p => new CombinationQueryPredicate<SearchTimeRangeValueQueryBuilderDsl>(p, SearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, TimeSpan> Lte()
        {
            return new ComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, TimeSpan>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<SearchTimeRangeValueQueryBuilderDsl>(p, SearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, TimeSpan> Lt()
        {
            return new ComparisonPredicateBuilder<SearchTimeRangeValueQueryBuilderDsl, TimeSpan>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lt")),
            p => new CombinationQueryPredicate<SearchTimeRangeValueQueryBuilderDsl>(p, SearchTimeRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
